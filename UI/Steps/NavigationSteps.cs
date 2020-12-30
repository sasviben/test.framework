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

            if (pageName.ToUpper().Equals(PageType.SUPERBET.ToString()) && !currentUrl.Contains(pageName.ToLower()))
                _navigationObject.NavigateToHomePage();
            else
                _navigationObject.NavigateToPage(pageName);
        }

        #endregion

    }
}
