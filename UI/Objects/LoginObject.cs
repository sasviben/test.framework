using NUnit.Framework;
using OpenQA.Selenium;
using UI.Configuration;
using UI.Helpers;
using UI.Locators;

namespace UI.Objects
{
    class LoginObject
    {
        public LoginObject(IWebDriver webDriver)
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
        ///     Enters player credentials and triggers login action by pressing the login button.
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///     Fail the test if the one or more elements are not visible in login web form within a specified time.
        /// </exception>
        /// 
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

        #endregion

        #region Assertions
        /// <summary>
        ///     Checks if the player balance element is visible in the DOM.
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

        #endregion
    }
}