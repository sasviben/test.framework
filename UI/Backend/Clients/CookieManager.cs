using OpenQA.Selenium;
using System.Collections.Generic;
using System.Net.Http;
using UI.Configuration;
using RestSharp;
using Newtonsoft.Json;
using UI.Backend.Models;
using Newtonsoft.Json.Linq;
using System;

namespace UI.Backend.Clients
{
    class CookieManager
    {
        public static List<Cookie> SeleniumCookies { get; set; } = new List<Cookie>();

        public static void ConvertHTTPCookieToSeleniumCookie()
        {
            var client = new RestClient(Settings.PlayerSessionAPI);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

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

        public static double GetPlayerBalance()
        {
            var client = new RestClient(Settings.PlayerBalanceAPI);
            var request = new RestRequest(Method.GET);

            if (SeleniumCookies == null)
                throw new NullReferenceException("Property CookieManager.SeleniumCookies is null! Please check the code.");
            request.AddHeader("Cookie", SeleniumCookies[1].ToString());

            var response = client.Execute(request);

            if (string.IsNullOrEmpty(response.Content))
                throw new ArgumentException("Response content shouldn't be null or empty! Please check the code.");
            var balanceResponse = JsonConvert.DeserializeObject<PlayerBalanceResponse>(response.Content);

            return balanceResponse.PlayerRecord.Accounts[0].Balance;
        }
    }
}

