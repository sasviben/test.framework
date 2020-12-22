using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace UI.Drivers
{
    class ChromeDriver
    {
        /// <summary>
        ///     Loads Chrome driver with desired options.
        /// </summary>
        /// <param name="headless">
        ///     Flag to run in headless mode.
        ///     Default: false
        /// </param>
        /// <returns>
        ///     IWebDriver with desired arguments set.
        /// </returns>
        public IWebDriver LoadChromeDriver(bool headless = false)
        {
            try
            {
                var driverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driverService.HideCommandPromptWindow = true;

                var options = new ChromeOptions();
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--window-size=1920,1080");
                options.AddArgument("--start-maximized");
                if (headless == true)
                    options.AddArgument("--headless");

                return new OpenQA.Selenium.Chrome.ChromeDriver(driverService, options);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
                return null;
            }
        }
        /// <summary>
        ///     Loads remote Chrome driver with desired options.
        /// </summary>
        /// <param name="remoteUri">
        ///     Remote Chrome driver uri. 
        /// </param>
        /// <param name="headless">
        ///     Flag to run in headless mode.
        ///     Default: true
        /// </param>
        /// <returns>
        ///     IWebDriver with desired arguments set.
        /// </returns>
        public IWebDriver LoadRemoteChromeDriver(Uri remoteUri, bool headless = true)
        {
            try
            {
                var options = new ChromeOptions();
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--window-size=1920,1080");
                options.AddArgument("--start-maximized");
                options.AddArgument("--disable-dev-shm-usage");
                if (headless == true)
                    options.AddArgument("--headless");

                var driver = new RemoteWebDriver(remoteUri, options);
                return driver;
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
                return null;
            }

        }
    }
}
