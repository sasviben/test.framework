using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;
using UI.Configuration;
using static UI.Helpers.Enums;

namespace UI.Hooks
{
    class ScenarioHooks
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;
        private readonly ConfigurationManager _configurationManager;
        private IWebDriver _driver;

        public ScenarioHooks(IObjectContainer objectContainer, ScenarioContext scenarioContext, IWebDriver webDriver)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
            _driver = webDriver;
            _configurationManager = new ConfigurationManager();
            _configurationManager.LoadConfiguration(_objectContainer);
        }

        #region Helpers
        /// <summary>
        ///     Loads defined browser.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     browserName is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        /// <exception cref="PlatformNotSupportedException">
        ///     Defined internet browser is not supported.
        /// </exception>
        private void LoadBrowser()
        {
            var browserName = Settings.Browser.ToUpper();
            if (!Enum.TryParse(browserName, out BrowserType browserTypeParsed))
                throw new ArgumentException("String " + browserName + " can't be parsed to enum!");

            switch (browserTypeParsed)
            {
                case BrowserType.CHROME:
                    {
                        var chromeDriver = new ChromeDriver();
#if DEBUG
                        _driver = chromeDriver.LoadChromeDriver();
#else
                        _driver = chromeDriver.LoadRemoteChromeDriver(new Uri(_environmentConfig.SeleniumHubUri), true);
#endif
                        break;
                    }
                case BrowserType.FIREFOX:
                    {
                        var firefoxDriver = new FirefoxDriver();
#if DEBUG
                        _driver = firefoxDriver.LoadFirefoxDriver();
#else
                        _driver = firefoxDriver.LoadRemoteFirefoxDriver(new Uri(_environmentConfig.SeleniumHubUri), true);
#endif
                        break;
                    }
                case BrowserType.IE:
                    {
                        var internetExplorerDriver = new InternetExplorerDriver();
#if DEBUG
                        _driver = internetExplorerDriver.LoadFirefoxDriver();
#else
                        _driver = internetExplorerDriver.LoadRemoteFirefoxDriver(new Uri(_environmentConfig.SeleniumHubUri), true);
#endif
                        break;
                    }
                default:
                    throw new PlatformNotSupportedException(Settings.Browser + " is not a supported browser!");
            }
            #endregion
        }
    }
}
