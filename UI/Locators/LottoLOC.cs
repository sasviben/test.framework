using OpenQA.Selenium;

namespace UI.Locators
{
    class LottoLOC
    {
        public static By GridEvents { get; } = By.CssSelector(".lotto-events-grid");
        public static By RowEvent { get; } = By.CssSelector(".lotto-event-row__header");
        public static By OptionRarestFiveNumbers { get; } = By.CssSelector("#item-index-0");
        public static By LottoEventDateTime { get; } = By.CssSelector(".lotto-event-row__header-info-date");
        public static By GridBall { get; } = By.CssSelector(".ball-grid__ball-wrapper");
    }
}
