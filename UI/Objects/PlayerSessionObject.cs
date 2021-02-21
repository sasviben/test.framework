using OpenQA.Selenium;
using UI.Backend.Clients;
using UI.Configuration;
using UI.Helpers;
using UI.Locators;

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

        public void OpenLoginModal()
        {
            _driver.WdFindElement(NavigationHeaderLOC.ButtonLogin).Click();

        }

        public void ExecuteLoginRequest()
        {
            foreach (var cookie in CookieManager.SeleniumCookies)
            {
                _driver.Manage().Cookies.AddCookie(cookie);
            }

            _driver.Navigate().Refresh();

        }

        public void Login()
        {
            _driver.WdFindElement(LoginFormLOC.FieldUsername).SendKeys(Settings.PlayerUsername);
            _driver.WdFindElement(LoginFormLOC.FieldPassword).SendKeys(Settings.PlayerPassword);
            _driver.WdFindElement(LoginFormLOC.ButtonSubmit).Click();

        }

        public void Logout()
        {
            var action = new OpenQA.Selenium.Interactions.Actions(_driver);

            var accountMenu = _driver.WdFindElement(NavigationHeaderLOC.PlayerAccount);
            action.MoveToElement(accountMenu).Build().Perform();

            _driver.WdFindElement(PlayerMenuLOC.ButtonLogout).Click();

        }

        #endregion

        #region Assertions
        public bool IsThePlayerLoggedIn()
        {
            return _driver.WdFindElement(PlayerMenuLOC.Balance).Displayed;

        }

        public bool IsThePlayerLoggedOut()
        {
            return _driver.WdFindElement(NavigationHeaderLOC.UserBar).Displayed;

        }

        #endregion
    }
}