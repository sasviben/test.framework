using NUnit.Framework;
using OpenQA.Selenium;
using System;
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
        /// <summary>
        ///     Opens login modal.
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///     Fail the test if the login modal is not visible within a specified time.
        /// </exception>
        public void OpenLoginModal()
        {
            try
            {
                _driver.WdFindElement(NavigationHeaderLOC.ButtonLogin).Click();
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }

        }

        /// <summary>
        ///    Executes login API request
        /// </summary>
        public void ExecuteLoginRequest()
        {
            try
            {
                foreach (var cookie in CookieManager.SeleniumCookies)
                {
                    _driver.Manage().Cookies.AddCookie(cookie);
                }

                _driver.Navigate().Refresh();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            IsTheUserLoggedIn();

        }

        /// <summary>
        ///     Enters player credentials and triggers login action by pressing the login button.
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///     Fail the test if the one or more elements are not visible in login web form within a specified time.
        /// </exception>
        public void Login()
        {
            try
            {
                _driver.WdFindElement(LoginFormLOC.FieldUsername).SendKeys(Settings.PlayerUsername);
                _driver.WdFindElement(LoginFormLOC.FieldPassword).SendKeys(Settings.PlayerPassword);
                _driver.WdFindElement(LoginFormLOC.ButtonSubmit).Click();
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }

        }

        /// <summary>
        ///    Logouts the player from web page.
        /// </summary>
        public void Logout()
        {
            try
            {
                var action = new OpenQA.Selenium.Interactions.Actions(_driver);

                var accountMenu = _driver.WdFindElement(NavigationHeaderLOC.PlayerAccount);
                action.MoveToElement(accountMenu).Build().Perform();

                _driver.WdFindElement(PlayerMenuLOC.ButtonLogout).Click();
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }

        }

        #endregion

        #region Assertions
        /// <summary>
        ///     Checks if the player's balance element is visible in the DOM. If true player is logged in.
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///     Fail the test if the player balance is not visible within a specified time.
        /// </exception>
        public void IsTheUserLoggedIn()
        {
            try
            {
                _driver.WdFindElement(PlayerMenuLOC.Balance, 20);
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }

        }
        /// <summary>
        ///    Checks if the user bar navigation element is visible in the DOM. If true player is logged out.
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///     Fail the test if the user bar navigation element is not visible within a specified time.
        /// </exception>
        public void IsTheUserLoggedOut()
        {
            try
            {
                _driver.WdFindElement(NavigationHeaderLOC.UserBar, 20);
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }
        }

        #endregion
    }
}