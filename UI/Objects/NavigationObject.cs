using NUnit.Framework;
using OpenQA.Selenium;
using UI.Configuration;
using UI.Helpers;
using UI.Locators;
using static UI.Helpers.Enums;

namespace UI.Objects
{
    class NavigationObject
    {
        private readonly IWebDriver _driver;

        public NavigationObject(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Actions
        /// <summary>
        ///   Opens homepage
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///    Fail the test if the SUPERBET logo is not visible within a specified time.
        /// </exception>
        public void NavigateToHomePage()
        {
            if (Settings.Browser.ToUpper().Equals(BrowserType.FIREFOX.ToString()))
                _driver.Navigate().GoToUrl(Settings.HomePageUrlFirefox);
            else
                _driver.Navigate().GoToUrl(Settings.HomePageUrl);

            try
            {
                _driver.WdFindElement(NavigationHeaderLOC.SuperbetLogo, 30);
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }

        }
        #endregion
    }
}