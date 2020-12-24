using BoDi;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using UI.Configuration;
using UI.Drivers;
using static UI.Helpers.Enums;

namespace UI.Hooks
{
    [Binding]
    class ScenarioHooks
    {
        public ScenarioHooks(AppConfiguration appConfig, IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _appConfiguration = appConfig;
            _scenarioContext = scenarioContext;
            _configurationManager = new ConfigurationManager();
            _configurationManager.LoadConfiguration(_objectContainer);
        }

        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;
        private readonly ConfigurationManager _configurationManager;
        private readonly AppConfiguration _appConfiguration;
        private IWebDriver _driver;

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
# endif
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
                default:
                    throw new PlatformNotSupportedException(Settings.Browser + " is not a supported browser!");
            }

            if (_driver != null)
                _objectContainer.RegisterInstanceAs(_driver);
        }
        #endregion

        /// <summary>
        ///     Initialize test scenario specific prerequisites before running scenario.
        /// </summary>
        [BeforeScenario]
        public void BeforeScenario()
        {
            var scenarioTags = _scenarioContext.ScenarioInfo.Tags.ToList();

            if (scenarioTags.Contains(UserType.SPORT.ToString()))
                _configurationManager.SetUserCredentials(UserType.SPORT.ToString());
            else if (scenarioTags.Contains(UserType.LOTTO.ToString()))
                _configurationManager.SetUserCredentials(UserType.LOTTO.ToString());
            else if (scenarioTags.Contains(UserType.GAMES.ToString()))
                _configurationManager.SetUserCredentials(UserType.GAMES.ToString());
            else
                _configurationManager.SetUserCredentials(UserType.RETAIL_BETTING.ToString());

            LoadBrowser();
        }

        /// <summary>
        ///     Clean up all objects in memory and processes after the test scenario is finished.
        /// </summary>
        [AfterScenario]
        public void AfterScenario()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }

    }
}
