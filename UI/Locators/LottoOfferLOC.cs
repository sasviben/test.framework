using OpenQA.Selenium;

namespace UI.Locators
{
    class LottoOfferLOC
    {
        public static By GridEvents { get; } = By.CssSelector(".lotto-events-grid");
        public static By RowEvent { get; } = By.CssSelector(".lotto-event-row__header");
        public static By OptionRarestFiveNumbers { get; } = By.CssSelector("#item-index-0");
    }
}
