using OpenQA.Selenium;
using System.Collections.Generic;
using System.Net.Http;
using UI.Configuration;
using RestSharp;
using Newtonsoft.Json;
using UI.Backend.Models;
using Newtonsoft.Json.Linq;

namespace UI.Backend.Clients
{
    class CookieManager
    {
        public static List<Cookie> SeleniumCookies { get; set; } = new List<Cookie>();

        /// <summary>
        ///     Sets HttpClient cookies from POST request.
        /// </summary>
        /// <exception cref="HttpRequestException">
        ///    HTTP request failure message.
        /// </exception>
        public static void ConvertHTTPCookieToSeleniumCookie()
        {
            var client = new RestClient(Settings.PlayerSessionAPI);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

            //Serialize to JSON body.
            JObject jObjectbody = new JObject
            {
                { "clientSourceType", Settings.ClientSourceType },
                { "password", Settings.PlayerPassword },
                { "username", Settings.PlayerUsername }
            };

            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            request.Timeout = 30000;


            var response = client.Execute(request);
            if (!response.IsSuccessful)
                throw new HttpRequestException($"Post request failed. \n Error message: {response.ErrorMessage}.\n Response status: {response.StatusCode}");

            foreach (var cookie in response.Cookies)
            {
                SeleniumCookies.Add(new Cookie(cookie.Name, cookie.Value, cookie.Domain, cookie.Path, cookie.Expires));
            }
        }
        
        /// <summary>
        ///    Gets player balance value by executing GET request.
        /// </summary>
        /// <returns>
        ///    Player balance double value.
        /// </returns>
        public static double GetPlayerBalance()
        {
            var client = new RestClient(Settings.PlayerBalanceAPI);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", SeleniumCookies.ToString());
            var response = client.Execute(request);

            var balanceResponse = JsonConvert.DeserializeObject<PlayerBalanceResponse>(response.Content);

            return balanceResponse.PlayerRecord.Accounts[0].Balance;
        }
    }
}

