using OpenQA.Selenium;
using System.Collections.Generic;

namespace web.test.app.models
{
    class EventModel
    {
        public string Day { get; set; }
        public string Time { get; set; }
        public string MarketName { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string ShopCode { get; set; }
        public Dictionary<IWebElement, List<string>> Odds { get; set; } = new Dictionary<IWebElement, List<string>>(); //key:odd element, value:[odd market name, odd value]
        public string LiveResults { get; set; }
        public string LiveTime { get; set; }

    }
}