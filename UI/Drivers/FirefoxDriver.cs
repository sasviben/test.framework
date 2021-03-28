using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;

namespace UI.Drivers
{
    class FirefoxDriver
    {
        public IWebDriver LoadFirefoxDriver(bool headless = false)
        {
            var driverService = FirefoxDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            try
            {
                driverService.HideCommandPromptWindow = true;
                driverService.Host = "::1";

                var options = new FirefoxOptions();
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--window-size=1920,1080");
                options.AddArguments("--disable-infobars");

                if (headless == true)
                    options.AddArgument("headless");

                var driver = new OpenQA.Selenium.Firefox.FirefoxDriver(driverService, options);
                driver.Manage().Window.Maximize();
                return driver;
            }
            catch (WebDriverException we)
            {
                throw new WebDriverException(we.Message);
            }

        }

        //public IWebDriver LoadRemoteFirefoxDriver(Uri remoteUri, bool headless = true)
        //{
        //    try
        //    {
        //        var options = new FirefoxOptions();
        //        options.AddArgument("disable-extensions");
        //        options.AddArgument("disable-popup-blocking");
        //        options.AddArgument("start-maximized");
        //        options.AddArgument("disable-dev-shm-usage");
        //        if (headless == true)
        //            options.AddArgument("headless");

        //        var driver = new RemoteWebDriver(remoteUri, options);
        //        return driver;
        //    }
        //    catch (WebDriverException we)
        //    {
        //        throw new WebDriverException(we.Message);
        //    }

        //}
    }
}
