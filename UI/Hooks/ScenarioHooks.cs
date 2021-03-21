using BoDi;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using UI.Configuration;
using UI.Drivers;
using UI.Models;
using static UI.Helpers.Enums;

namespace UI.Hooks
{
    [Binding]
    class ScenarioHooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        private readonly ConfigurationManager _configurationManager;

        public ScenarioHooks(AppConfiguration appConfig, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext, PlayerDetailsModel playerDetails)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
            _configurationManager = new ConfigurationManager(playerDetails);
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
                        _driver = chromeDriver.LoadChromeDriver();
                        
                        break;
                    }
                case BrowserType.FIREFOX:
                    {
                        var firefoxDriver = new FirefoxDriver();

                        _driver = firefoxDriver.LoadFirefoxDriver();
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
      
            if (_featureContext.FeatureInfo.Title.Equals("Sport Online Betting"))
                _configurationManager.SetUserCredentials(UserType.SPORT.ToString());

            else if (_featureContext.FeatureInfo.Title.Equals("Lotto Online Betting"))
                _configurationManager.SetUserCredentials(UserType.LOTTO.ToString());
            else if (_featureContext.FeatureInfo.Title.Equals("Games Online Betting"))
                _configurationManager.SetUserCredentials(UserType.GAMES.ToString());
            else if (_featureContext.FeatureInfo.Title.Equals("Player Session"))
                _configurationManager.SetUserCredentials(UserType.RETAIL_BETTING.ToString());
            else if (_featureContext.FeatureInfo.Title.Equals("Navigation"))
            {
                if (scenarioTags.Contains("online"))
                    _configurationManager.SetUserCredentials(UserType.SPORT.ToString());
            }

            LoadBrowser();
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
