using OpenQA.Selenium;

namespace UI.Locators
{
    class SportOfferLOC
    {
        public static By NavigationFootball { get; } = By.CssSelector(".e2e-5");
        public static By NavigationSpecial { get; } = By.CssSelector(".nav-sidebar-superbets");
        public static By Prematch { get; } = By.CssSelector(".offer--prematch");
        public static By Inplay { get; } = By.CssSelector(".offer--live");
        public static By Matches { get; } = By.CssSelector(".items .event-row-container");

    }
}
