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
        /// <exception cref="NoSuchElementException">
        ///     Element is not in the DOM.
        /// </exception>
        public void OpenLoginModal()
        {
            try
            {
                _driver.FindElement(NavigationHeaderLOC.ButtonLogin).Click();
            }
            catch (NoSuchElementException e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        ///     Enters player credentials and triggers login action by pressing the login button.
        /// </summary>
        /// <exception cref="NoSuchElementException">
        ///     Fail the test if the element is not visible in DOM.
        /// </exception>
        /// 
        public void Login()
        {
            try
            {
                _driver.FindElement(LoginFormLOC.FieldUsername).SendKeys(Settings.PlayerUsername);
                _driver.FindElement(LoginFormLOC.FieldPassword).SendKeys(Settings.PlayerPassword);

                _driver.FindElement(LoginFormLOC.ButtonSubmit).Click();
                
            }
            catch (NoSuchElementException e)
            {
                Assert.Fail(e.Message);
            }
        }

        #endregion

        #region Assertions
        /// <summary>
        ///     Checks if the player balance element is visible in the DOM.
        /// </summary>
        public void IsTheUserLoggedIn()
        {
            Assert.IsTrue(Waiters.WaitUntilElementIsVisible(PlayerMenuLOC.Balance, _driver, 30), "Can't find player balance element in the DOM! Timeout after 30 seconds.");
        }

        #endregion
    }
}