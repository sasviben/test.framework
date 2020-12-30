using OpenQA.Selenium;

namespace UI.Locators
{
    class PrematchOfferLOC
    {
        public static By NavigationFootball { get; } = By.CssSelector(".e2e-5");
        public static By Offer { get; } = By.CssSelector(".offer--prematch");
    }
}
