using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace UI.Drivers
{
    class FirefoxDriver
    {
        /// <summary>
        ///     Loads Firefox driver with desired options.
        /// </summary>
        /// <param name="headless">
        ///     Flag to run in headless mode.
        ///     Default: false
        /// </param>
        /// <returns>
        ///     IWebDriver with desired arguments set.
        /// </returns>
        public IWebDriver LoadFirefoxDriver(bool headless = false)
        {
            var driverService = FirefoxDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driverService.HideCommandPromptWindow = true;

            var options = new FirefoxOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--window-size=1920,1080");
            options.AddArgument("--start-maximized");
            if (headless == true)
                options.AddArgument("--headless");

            var driver = new OpenQA.Selenium.Firefox.FirefoxDriver(driverService, options);
            return driver;
        }
        /// <summary>
        ///     Loads remote Firefox driver with desired options.
        /// </summary>
        /// <param name="remoteUri">
        ///     Remote Firefox driver uri. 
        /// </param>
        /// <param name="headless">
        ///     Flag to run in headless mode.
        ///     Default: true
        /// </param>
        /// <returns>
        ///     IWebDriver with desired arguments set.
        /// </returns>
        public IWebDriver LoadRemoteFirefoxDriver(Uri remoteUri, bool headless = true)
        {
            var options = new FirefoxOptions();
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
    }
}
