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
        private static string _cookieNameAndValue;
        public static void SetCookieNameAndValue()
        {
            var client = new RestClient(Settings.PlayerSessionAPI);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

            var jObjectbody = new JObject
            {
                { "clientSourceType", Settings.ClientSourceType },
                { "password", Settings.PlayerPassword },
                { "username", Settings.PlayerUsername }
            };

            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            request.Timeout = 30000;

            var response = client.Execute(request);
            if (!response.IsSuccessful || response.Content.Contains("{\"error\":true"))
                throw new HttpRequestException($"Request failed. \n Error message: {response.ErrorMessage}.\n Response status: {response.StatusCode}. \n Response content: {response.Content}.");

            foreach (var cookie in response.Cookies)
            {
                if (cookie.Name.Equals(Settings.Cookie))
                    _cookieNameAndValue = $"{cookie.Name}={cookie.Value}";
            }

        }

        public static double GetPlayerBalance()
        {
            var client = new RestClient(Settings.PlayerBalanceAPI);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Cookie", _cookieNameAndValue);

            var response = client.Execute(request);

            if (!response.IsSuccessful || response.Content.Contains("{\"error\":true"))
                throw new HttpRequestException($"Request failed. \n Error message: {response.ErrorMessage}.\n Response status: {response.StatusCode}. \n Response content: {response.Content}.");

            var balanceResponse = JsonConvert.DeserializeObject<PlayerBalanceResponse>(response.Content);

            return balanceResponse.PlayerRecord.Accounts[0].Balance;
        }
    }
}
