using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Linq;
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
        private readonly AppConfiguration _appConfiguration;
        private IWebDriver _driver;

        public ScenarioHooks(AppConfiguration appConfig, IObjectContainer objectContainer, ScenarioContext scenarioContext, IWebDriver webDriver)
        {
            _appConfiguration = appConfig;
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
                        _driver = chromeDriver.LoadRemoteChromeDriver(new Uri(_appConfiguration.SeleniumHubUri), true);
#endif
                        break;
                    }
                case BrowserType.FIREFOX:
                    {
                        var firefoxDriver = new FirefoxDriver();
#if DEBUG
                        _driver = firefoxDriver.LoadFirefoxDriver();
#else
                        _driver = firefoxDriver.LoadRemoteFirefoxDriver(new Uri(_appConfiguration.SeleniumHubUri), true);
#endif
                        break;
                    }
                case BrowserType.IE:
                    {
                        var internetExplorerDriver = new InternetExplorerDriver();
#if DEBUG
                        _driver = internetExplorerDriver.LoadFirefoxDriver();
#else
                        _driver = internetExplorerDriver.LoadRemoteFirefoxDriver(new Uri(_appConfiguration.SeleniumHubUri), true);
#endif
                        break;
                    }
                default:
                    throw new PlatformNotSupportedException(Settings.Browser + " is not a supported browser!");
            }
        }
        #endregion

        /// <summary>
        ///     Initialize test scenario specific prerequisites before running scenario.
        /// </summary>
        [BeforeScenario]
        public void Initialize()
        {
            var scenarioTags = _scenarioContext.ScenarioInfo.Tags.ToList();

            if (scenarioTags.Contains(UserType.SPORT.ToString()))
                _configurationManager.SetUserCredentials(UserType.SPORT);
            else if (scenarioTags.Contains(UserType.LOTTO.ToString()))
                _configurationManager.SetUserCredentials(UserType.LOTTO);
            else if (scenarioTags.Contains(UserType.GAMES.ToString()))
                _configurationManager.SetUserCredentials(UserType.GAMES);
            else
                _configurationManager.SetUserCredentials(UserType.RETAIL_BETTING);

            LoadBrowser();
        }

        /// <summary>
        ///     Clean up all objects in memory and processes after the test scenario is finished.
        /// </summary>
        [AfterScenario]
        public void CleanUp()
        {
            _objectContainer.Dispose();
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
