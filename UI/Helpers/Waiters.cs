using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UI.Helpers
{
    public static class Waiters
    {
        /// <summary>
        ///     Wait until element is visible in DOM by its locator.
        /// </summary>
        /// <param name="locator">
        ///     Locator pointing to the web element.
        /// </param>
        /// <param name="driver">
        ///     Instance of Selenium IWebDriver.
        /// </param>
        /// <param name="seconds">
        ///     Time in seconds to wait for element become visible.
        ///     Default: 10 seconds
        /// </param>
        /// <returns>
        ///     IWebElement. 
        /// </returns>
        public static bool WaitUntilElementIsVisible(By locator, IWebDriver driver, int seconds = 10)
        {
            var browserWait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return browserWait.Until(driver => driver.FindElement(locator).Displayed);
        }
    }
}
