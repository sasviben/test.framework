using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UI.Objects;

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
        /// <summary>
        ///     Step for player web navigation.
        /// </summary>
        /// <param name="pageName">
        ///     Name of page to navigate.
        /// </param>
        [Given(@"the player is on the page ""(.*)""")]
        public void GivenThePlayerIsOnThePage(string pageName)
        {
            string currentUrl = _driver.Url;
            if (!currentUrl.Contains(pageName.ToLower()))
                _navigationObject.NavigateToHomePage();
        }

        #endregion

    }
}
