using OpenQA.Selenium;
using UI.Backend.Clients;
using UI.Configuration;
using UI.Helpers;
using UI.Locators;
using UI.Models;

namespace UI.Objects
{
    class PlayerSessionObject
    {
        public PlayerSessionObject(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        private readonly IWebDriver _driver;

        #region Actions
        /// <summary>
        ///    Opens login modal.
        /// </summary>
        public void OpenLoginModal()
        {
            _driver.WdFindElement(NavigationHeaderLOC.ButtonLogin).Click();

        }

        /// <summary>
        ///    Executes login API request
        /// </summary>
        public void ExecuteLoginRequest()
        {
            foreach (var cookie in CookieManager.SeleniumCookies)
            {
                _driver.Manage().Cookies.AddCookie(cookie);
            }

            _driver.Navigate().Refresh();

        }

        /// <summary>
        ///    Enters player credentials and triggers login action by pressing the login button.
        /// </summary>
        public void Login()
        {
            _driver.WdFindElement(LoginFormLOC.FieldUsername).SendKeys(Settings.PlayerUsername);
            _driver.WdFindElement(LoginFormLOC.FieldPassword).SendKeys(Settings.PlayerPassword);
            _driver.WdFindElement(LoginFormLOC.ButtonSubmit).Click();

            PlayerProfileModel.BalanceAfterLogin = CookieManager.GetPlayerBalance();

        }

        /// <summary>
        ///    Logouts the player from web page.
        /// </summary>
        public void Logout()
        {
            var action = new OpenQA.Selenium.Interactions.Actions(_driver);

            var accountMenu = _driver.WdFindElement(NavigationHeaderLOC.PlayerAccount);
            action.MoveToElement(accountMenu).Build().Perform();

            _driver.WdFindElement(PlayerMenuLOC.ButtonLogout).Click();

        }

        #endregion

        #region Assertions
        /// <summary>
        ///     Checks if the player's balance element is visible in the DOM.
        /// </summary>
        /// <returns>
        ///    True if player is logged in, else false.
        /// </returns>
        public bool IsThePlayerLoggedIn()
        {
            return _driver.WdFindElement(PlayerMenuLOC.Balance, 20).Displayed;

        }
        /// <summary>
        ///    Checks if the user bar navigation element is visible in the DOM.
        /// </summary>
        /// <returns>
        ///    True if player is logged out, else false.
        /// </returns>
        public bool IsThePlayerLoggedOut()
        {
            return _driver.WdFindElement(NavigationHeaderLOC.UserBar, 20).Displayed;

        }

        #endregion
    }
}