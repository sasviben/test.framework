using OpenQA.Selenium;

namespace UI.Locators
{
    class PlayerMenuLOC
    {
        public static By Balance { get; } = By.CssSelector(".balance");
        public static By NavigationAccountOverview { get; } = By.CssSelector(".e2e_player-account");
        public static By NavigationTickets { get; } = By.CssSelector(".e2e_player-tickets");
        public static By NavigationTransactionsHistory { get; } = By.CssSelector(".e2e_player-history");
        public static By ButtonLogout { get; } = By.CssSelector("#nav-account-logout");
    }
}
