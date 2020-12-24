﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace UI.Helpers
{
    static class WebDriverExtensions
    {
        public static IWebElement WdFindElement(this IWebDriver driver, By by, int sec = 10)
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
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverTimeoutException($"Method WdFindElement can not find element with locator: {by} in the DOM.\n {te.Message}");
            }

        }

        public static IList<IWebElement> WdFindElements(this IWebDriver driver, By by, int sec = 10)
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
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverTimeoutException($"Method WdFindElements can not find element with locator: {by} in the DOM.\n{te.Message}");
            }
        }

        public static object WdHighlight(this By by, IWebDriver driver, int sec)
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
                return js.ExecuteScript(HighlightSettings.WdHighlightedColor, myLocator);
            }
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverTimeoutException($"Method WdHighlight can not find element with locator: {by} in the DOM. \n {te.Message}");
            }
        }
    }
}
