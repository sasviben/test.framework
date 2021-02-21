using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace UI.Helpers
{
    static class WebDriverExtensions
    {
        /// <summary>
        ///    Finds web element with driver in the DOM.
        /// </summary>
        /// <param name="driver">
        ///    IWebDriver driver instance.
        /// </param>
        /// <param name="by">
        ///    Locator of the web element.
        /// </param>
        /// <param name="sec">
        ///    Time to wait for driver to find the web element.
        ///    Default time is 10 seconds.
        /// </param>
        /// <returns>
        ///    Web element specified by locator.
        /// </returns>
        /// <exception cref="WebDriverTimeoutException">
        ///    Driver finding the web element timeouts after the specified time.
        /// </exception>
        public static IWebElement WdFindElement(this IWebDriver driver, By by, int sec = 60)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
                return wait.Until(drv =>
                {
                    try
                    {
                        by.WdHighlight(driver, sec);
                        return drv.FindElement(by);
                    }
                    catch (NoSuchElementException)
                    {
                        return null;
                    }
                }
                );
            }
            catch (WebDriverTimeoutException te) { throw new WebDriverTimeoutException($"Method WdFindElement can not find element with locator: {by}.\n{te.Message}."); }

        }

        /// <summary>
        ///    Finds web elements with driver in the DOM.
        /// </summary>
        /// <param name="driver">
        ///    IWebDriver driver instance.
        /// </param>
        /// <param name="by">
        ///    Locator of the web element.
        /// </param>
        /// <param name="sec">
        ///    Time to wait for driver to find the web element.
        ///    Default time is 10 seconds.
        /// </param>
        /// <returns>
        ///    List of web elements specified by locator.
        /// </returns>
        /// <exception cref="WebDriverTimeoutException">
        ///    Driver finding the web element timeouts after the specified time.
        /// </exception>
        public static IList<IWebElement> WdFindElements(this IWebDriver driver, By by, int sec = 60)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
                return wait.Until(drv =>
                {
                    try
                    {
                        by.WdHighlight(driver, sec);
                        return driver.FindElements(by);
                    }
                    catch (NoSuchElementException)
                    {
                        return null;
                    }
                });
            }
            catch (WebDriverTimeoutException te) { throw new WebDriverTimeoutException($"Method WdFindElements can not find element with locator: {by}.\n{te.Message}"); }

        }

        /// <summary>
        ///    Highlights founded element in the DOM.
        /// </summary>
        /// <param name="by">
        ///    Locator of the web element.
        ///  </param>
        /// <param name="driver">
        ///    IWebDriver driver instance.
        /// </param>
        /// <param name="sec">
        ///    Time to wait for driver to find the web element.
        ///    Default time is 10 seconds.
        /// </param>
        /// <exception cref="WebDriverTimeoutException">
        ///    Driver finding the web element timeouts after the specified time.
        /// </exception>
        public static void WdHighlight(this By by, IWebDriver driver, int sec)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));

                var myLocator = wait.Until(drv =>
                {
                    try
                    {
                        return driver.FindElement(by);
                    }
                    catch (NoSuchElementException)
                    {
                        return null;
                    }
                });

                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript(HighlightSettings.WdHighlightedColor, myLocator);
            }
            catch (WebDriverTimeoutException te) { throw new WebDriverTimeoutException($"Method WdHighlight can not find and highlight element with locator: {by}.\n{te.Message}"); }

        }

        /// <summary>
        ///    Hovers founded element in the DOM.
        /// </summary>
        /// <param name="driver">
        ///    IWebDriver driver instance.
        /// </param>
        /// <param name="by">
        ///    Locator of the web element.
        ///  </param>
        /// <exception cref="WebDriverTimeoutException">
        ///    Driver finding the web element timeouts after the specified time.
        /// </exception>
        public static void WdMoveToElement(this IWebDriver driver, By by)
        {
            try
            {
                var webElement = driver.WdFindElement(by);

                Actions action = new Actions(driver);
                action.MoveToElement(webElement);
                action.Perform();
            }
            catch (WebDriverTimeoutException te) { throw new WebDriverTimeoutException($"Method WdMoveToElement can not find and hover element with locator: {by}.\n{te.Message}"); }

        }

        /// <summary>
        ///     Wait until element is invisible in DOM by its locator.
        /// </summary>
        /// <param name="by">
        ///     Locator pointing to the web element.
        /// </param>
        /// <param name="driver">
        ///     Instance of Selenium IWebDriver.
        /// </param>
        /// <param name="seconds">
        ///     Time in seconds to wait for element become invisible.
        ///     Default: 10 seconds
        /// </param>
        /// <exception cref="WebDriverTimeoutException">
        ///    Driver finding the web element timeouts after the specified time.
        /// </exception>
        public static void WaitUntilElementIsInvisible(this IWebDriver driver, By by, int sec = 60)
        {
            var browserWait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));

            if (!browserWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(by)))
                throw new WebDriverTimeoutException($"Element with locator: {by} is not invisible after specified time to wait!");
        }

        /// <summary>
        ///    Checks if element is visible in DOM by its locator.
        /// </summary>
        /// <param name="by">
        ///    Locator pointing to the web element.
        /// </param>
        /// <param name="driver">
        ///    Instance of Selenium IWebDriver.
        /// </param>
        /// <param name="sec">
        ///     Time in seconds to wait for element become invisible.
        ///     Default: 10 seconds
        /// </param>
        /// <returns>
        ///    True if element is visible or false if element is not visible.
        /// </returns>
        public static bool WdIsElementVisible(this IWebDriver driver, By by, int sec = 60)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                driver.WdFindElement(by).WeHighlightElement(driver);
                return true;
            }
            catch { return false; }
        }

    }
}

