using BoDi;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using UI.Backend.Clients;
using UI.Configuration;
using UI.Drivers;
using web.test.app.hooks;
using static UI.Helpers.Enums;

namespace UI.Hooks
{
    [Binding]
    class ScenarioHooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly AppConfiguration _appConfiguration;
        private readonly ConfigurationManager _configurationManager;
        public ScenarioHooks(AppConfiguration appConfig, IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _appConfiguration = appConfig;
            _scenarioContext = scenarioContext;
            _configurationManager = new ConfigurationManager();
            _configurationManager.LoadConfiguration(_objectContainer);
        }

        #region Helpers

        private void LoadBrowser()
        {
            if (!Enum.TryParse(Settings.Browser, true, out BrowserType browserTypeParsed))
                throw new ArgumentException($"String {Settings.Browser} can't be parsed to BrowserType enum!");

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
                    throw new PlatformNotSupportedException($"{Settings.Browser} is not a supported browser!");
            }

            if (_driver != null)
                _objectContainer.RegisterInstanceAs(_driver);
        }
        #endregion

        [BeforeScenario]
        public void BeforeScenario()
        {
            var scenarioTags = _scenarioContext.ScenarioInfo.Tags.ToList();

            if (FeatureHooks.Feature.Equals("Sport Online Betting"))
                _configurationManager.SetUserCredentials(UserType.SPORT.ToString());
            else if (FeatureHooks.Feature.Equals("Lotto Online Betting"))
                _configurationManager.SetUserCredentials(UserType.LOTTO.ToString());
            else if (FeatureHooks.Feature.Equals("Games Online Betting"))
                _configurationManager.SetUserCredentials(UserType.GAMES.ToString());
            else if (FeatureHooks.Feature.Equals("Player Session"))
                _configurationManager.SetUserCredentials(UserType.RETAIL_BETTING.ToString());
            else if (FeatureHooks.Feature.Equals("Navigation"))
            {
                if (scenarioTags.Contains("online"))
                    _configurationManager.SetUserCredentials(UserType.SPORT.ToString());
            }

            LoadBrowser();
            CookieManager.ConvertHTTPCookieToSeleniumCookie();

        }

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
