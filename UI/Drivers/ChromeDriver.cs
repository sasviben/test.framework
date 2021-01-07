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
        ///    Loads Chrome driver with desired options.
        /// </summary>
        /// <param name="headless">
        ///    Flag to run in headless mode.
        ///    Default: false
        /// </param>
        /// <returns>
        ///    IWebDriver with desired arguments set.
        /// </returns>
        /// <exception cref="WebDriverException">
        ///    Problem with loading Chrome Driver.
        /// </exception>
        public IWebDriver LoadChromeDriver(bool headless = false)
        {
            var driverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            try
            {
                driverService.HideCommandPromptWindow = true;

                var options = new ChromeOptions();

                options.AddArgument("--start-maximized");
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-popup-blocking");
                
                if (headless == true)
                    options.AddArgument("--headless");

                return new OpenQA.Selenium.Chrome.ChromeDriver(driverService, options);
            }
            catch (WebDriverException we)
            {
                if (driverService != null)
                    driverService.Dispose();
                throw new WebDriverException(we.Message);
            }
        }
        /// <summary>
        ///    Loads remote Chrome driver with desired options.
        /// </summary>
        /// <param name="remoteUri">
        ///    Remote Chrome driver uri. 
        /// </param>
        /// <param name="headless">
        ///    Flag to run in headless mode.
        ///    Default: true
        /// </param>
        /// <returns>
        ///    IWebDriver with desired arguments set.
        /// </returns>
        /// <exception cref="WebDriverException">
        ///    Problem with loading remote Chrome driver.
        /// </exception>
        public IWebDriver LoadRemoteChromeDriver(Uri remoteUri, bool headless = true)
        {
            try
            {
                var options = new ChromeOptions();
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--start-maximized");
                options.AddArgument("--disable-dev-shm-usage");
                if (headless == true)
                    options.AddArgument("--headless");

                var driver = new RemoteWebDriver(remoteUri, options);
                return driver;
            }
            catch (WebDriverException we)
            {
                throw new WebDriverException(we.Message);
            }

        }
    }
}
