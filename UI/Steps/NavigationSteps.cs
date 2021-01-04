using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UI.Objects;
using static UI.Helpers.Enums;

namespace UI.Steps
{
    [Binding]
    class NavigationSteps
    {
        public NavigationSteps(IWebDriver driver)
        {
            _driver = driver;
            _navigationObject = new NavigationObject(_driver);
        }

        private readonly IWebDriver _driver;
        private readonly NavigationObject _navigationObject;

        #region Actions
        [Given(@"the player is on the page ""(.*)""")]
        public void GivenThePlayerIsOnThePage(string pageName)
        {
            string currentUrl = _driver.Url;

            if (!currentUrl.Contains(PageType.SUPERBET.ToString().ToLower()))
                _navigationObject.NavigateToHomePage();

            if (!pageName.ToUpper().Equals(PageType.SUPERBET.ToString()))
                _navigationObject.NavigateToMainPage(pageName);
        }

        [When(@"the player clicks on the page ""(.*)""")]
        public void WhenThePlayerClicksOnThePage(string pageName)
        {
            _navigationObject.NavigateToMainPage(pageName);
        }

        #endregion
        #region Assertions
        [Then(@"the ""(.*)"" page is displayed")]
        public void ThenThePageIsDisplayed(string pageName)
        {
            _navigationObject.IsThePageDisplayed(pageName);
        }

        #endregion

    }
}
