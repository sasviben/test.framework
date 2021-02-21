using OpenQA.Selenium;
using System.Collections.Generic;

namespace web.test.app.models
{
    class EventModel
    {
        public static string Day { get; set; }
        public static string Time { get; set; }
        public static string MarketName { get; set; }
        public static string HomeTeamName { get; set; }
        public static string AwayTeamName { get; set; }
        public static string ShopCode { get; set; }
        public static Dictionary<IWebElement, List<string>> Odds { get; set; } = new Dictionary<IWebElement, List<string>>(); //key:odd element, value:[odd market name, odd value]
        public static string LiveResults { get; set; }
        public static string LiveTime { get; set; }

    }
}