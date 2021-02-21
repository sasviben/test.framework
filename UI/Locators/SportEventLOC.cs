using OpenQA.Selenium;

namespace UI.Locators
{
    class SportEventLOC
    {
        public static By Day { get; } = By.CssSelector(".event-summary__match-indicator-day");
        public static By Time { get; } = By.CssSelector(".event-summary__match-indicator-time");
        public static By HomeTeamName { get; } = By.CssSelector(".event-summary__competitors-team1");
        public static By AwayTeamName { get; } = By.CssSelector(".event-summary__competitors-team2");
        public static By ContainerOdd { get; } = By.CssSelector(".pick");
        public static By OddMarketName { get; } = By.CssSelector(".market");
        public static By OddValue { get; } = By.CssSelector(".odd .new");
        public static By LiveResults { get; } = By.CssSelector(".live-score-widget__score");
        public static By LiveIndicator { get; } = By.CssSelector(".event-summary__match-indicator-live");
        public static By LiveTime { get; } = By.CssSelector(".event-summary__match-indicator-period");
    }
}
