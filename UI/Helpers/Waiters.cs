using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UI.Helpers
{
    public static class Waiters
    {
        /// <summary>
        ///     Checks if element is visible in DOM by its locator.
        /// </summary>
        /// <param name="locator">
        ///     Locator pointing to the web element.
        /// </param>
        /// <param name="driver">
        ///     Instance of Selenium IWebDriver.
        /// </param>
        /// <param name="seconds">
        ///     Time to wait for element become visible.
        ///     Default: 10 seconds
        /// </param>
        /// <returns>
        ///     True if element is visible.
        ///     False if element isn't visible in a specified timeframe.
        /// </returns>
        public static bool IsElementVisible(By locator, IWebDriver driver, int seconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));   
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
