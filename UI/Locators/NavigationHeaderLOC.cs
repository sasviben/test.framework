using OpenQA.Selenium;

namespace UI.Locators
{
    class NavigationHeaderLOC
    {
        public static By UserBar { get; } = By.CssSelector(".user-bar");
        public static By ButtonLogin { get; } = By.CssSelector("#nav-login");
        public static By SuperbetLogo { get; } = By.CssSelector("#sb-logo");
        public static By Sport { get; } = By.CssSelector("#nav-desktop-sport");
        public static By Live { get; } = By.CssSelector("#nav-desktop-live");
        public static By Games { get; } = By.CssSelector("#nav-desktop-games");
        public static By Casino { get; } = By.CssSelector("#nav-desktop-casino");
        public static By Lotto { get; } = By.CssSelector("#nav-desktop-lotto");
        public static By Virtual { get; } = By.CssSelector("#nav-desktop-virtual");
        public static By News { get; } = By.CssSelector("#nav-desktop-news");
        public static By Results { get; } = By.CssSelector("#nav-desktop-results");
        public static By Shops { get; } = By.CssSelector("#nav-desktop-shops");
        public static By Help { get; } = By.CssSelector("#nav-desktop-help");
        public static By Promotions { get; } = By.CssSelector("#nav-desktop-promotions");
        public static By PlayerAccount { get; } = By.CssSelector(".user-info");
        public static By Spinner { get; } = By.CssSelector(".spinner-container");
    }
}
