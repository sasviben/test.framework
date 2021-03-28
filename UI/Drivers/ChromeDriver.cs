using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace UI.Drivers
{
    class ChromeDriver
    {
        public IWebDriver LoadChromeDriver(bool headless = false)
        {
            var driverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            try
            {
                driverService.HideCommandPromptWindow = true;

                var options = new ChromeOptions();

                options.AddArgument("start-maximized");
                options.AddArgument("disable-extensions");
                options.AddArgument("disable-popup-blocking");
                options.AddExcludedArgument("enable-automation");
                options.AddArguments("disable-infobars");

                if (headless == true)
                    options.AddArgument("headless");

                return new OpenQA.Selenium.Chrome.ChromeDriver(driverService, options);
            }
            catch (WebDriverException we)
            {
                throw new WebDriverException(we.Message);
            }
        }
        //public IWebDriver LoadRemoteChromeDriver(Uri remoteUri, bool headless = true)
        //{
        //    try
        //    {
        //        var options = new ChromeOptions();
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
