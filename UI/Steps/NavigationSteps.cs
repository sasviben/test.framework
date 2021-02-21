using NUnit.Framework;
using OpenQA.Selenium;
using System;
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
        private const string URL_SUPERBET = "SUPERBET";

        #region Actions
        [Given(@"the player is on the page ""(.*)""")]
        public void GivenThePlayerIsOnThePage(string pageName)
        {
            string currentUrl = _driver.Url;

            try
            {
                if (!currentUrl.Contains(URL_SUPERBET, StringComparison.OrdinalIgnoreCase))
                    _navigationObject.NavigateToHomePage();

                if (!pageName.ToUpper().Equals(URL_SUPERBET, StringComparison.OrdinalIgnoreCase))
                    _navigationObject.NavigateToMainPage(pageName);
            }
            catch (Exception e) { Assert.Fail($"Step 'the player is on the page {pageName}' failed! {e.Message}"); }

        }

        [When(@"the player clicks on the page ""(.*)""")]
        public void WhenThePlayerClicksOnThePage(string pageName)
        {
            try
            {
                _navigationObject.NavigateToMainPage(pageName);
            }
            catch (Exception e) { Assert.Fail($"Step 'the player clicks on the page {pageName}' failed! {e.Message}"); }

        }

        #endregion

        #region Assertions
        [Then(@"the ""(.*)"" page is displayed")]
        public void ThenThePageIsDisplayed(string pageName)
        {
            try
            {
                _navigationObject.IsThePageDisplayed(pageName);
            }
            catch (Exception e) { Assert.Fail($"Step 'the {pageName} page is displayed' failed! {e.Message}"); }

        }

        #endregion

    }
}
