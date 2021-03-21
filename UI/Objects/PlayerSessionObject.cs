using OpenQA.Selenium;
using UI.Backend.Clients;
using UI.Helpers;
using UI.Locators;
using UI.Models;

namespace UI.Objects
{
    class PlayerSessionObject
    {
        private readonly IWebDriver _driver;
        private readonly PlayerDetailsModel _playerCredentials;
        public PlayerSessionObject(IWebDriver webDriver, PlayerDetailsModel playerDetails)
        {
            _driver = webDriver;
            _playerCredentials = playerDetails;
        }


        #region Actions

        public void OpenLoginModal()
        {
            _driver.WdFindElement(NavigationHeaderLOC.ButtonLogin).Click();

        }

        public void Login()
        {
            _driver.WdFindElement(LoginFormLOC.FieldUsername).SendKeys(_playerCredentials.PlayerUsername);
            _driver.WdFindElement(LoginFormLOC.FieldPassword).SendKeys(_playerCredentials.PlayerPassword);
            _driver.WdFindElement(LoginFormLOC.ButtonSubmit).Click();

            var cookieManager = new CookieManager(_playerCredentials);
            cookieManager.SetCookieNameAndValue();
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