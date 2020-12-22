using NUnit.Framework;
using OpenQA.Selenium;
using System;
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

        /// <summary>
        ///    Opens homepage
        /// </summary>
        public void NavigateToHomePage()
        {
            if (Settings.Browser.ToUpper().Equals(BrowserType.FIREFOX.ToString()))
                _driver.Navigate().GoToUrl(Settings.HomePageUrlFirefox);
            else
                _driver.Navigate().GoToUrl(Settings.HomePageUrl);

            Assert.True(Waiters.WaitUntilElementIsVisible(NavigationHeaderLOC.SuperbetLogo, _driver, 30),
                        "Accessing Superbet's homepage timeout after 30 seconds!");
        }
    }
}