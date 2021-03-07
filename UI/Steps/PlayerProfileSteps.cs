using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UI.Backend.Clients;
using UI.Helpers;
using UI.Locators;
using UI.Models;
using UI.Objects;

namespace UI.Steps
{
    [Binding]
    class PlayerProfileSteps
    {
        private readonly IWebDriver _driver;
        private readonly PlayerSessionObject _playerSessionObject;
        private readonly NavigationObject _navigationObject;

        public PlayerProfileSteps(IWebDriver webDriver)
        {
            _driver = webDriver;
            _playerSessionObject = new PlayerSessionObject(_driver);
            _navigationObject = new NavigationObject(_driver);
        }


        #region Actions
        [When(@"the player tries to log in with valid credentials")]
        public void WhenThePlayerTriesToLogInWithValidCredentials()
        {
            try
            {
                _playerSessionObject.OpenLoginModal();
                _playerSessionObject.Login();
            }
            catch (Exception e) { Assert.Fail($"Step 'the player tries to log in with valid credentials' failed! {e.Message}"); }
        }

        [Given(@"the player is logged in")]
        public void GivenThePlayerIsLoggedIn()
        {
            try
            {
                _navigationObject.NavigateToHomePage();
                _playerSessionObject.OpenLoginModal();
                _playerSessionObject.Login();
                _driver.WdFindElement(NavigationHeaderLOC.SuperbetLogo);

                Assert.IsTrue(_playerSessionObject.IsThePlayerLoggedIn(), "Player login failed!");
                PlayerProfileModel.BalanceAfterLogin = CookieManager.GetPlayerBalance();
                _driver.WdFindElement(PopUpModals.ButtonAcceptCookies).Click();
            }
            catch (Exception e) { Assert.Fail($"Step 'the player is logged in' failed! {e.Message}"); }

        }

        [When(@"the player tries to logout")]
        public void WhenThePlayerTriesToLogout()
        {
            try
            {
                _playerSessionObject.Logout();
            }
            catch (Exception e) { Assert.Fail($"Step 'the player tries to logout' failed! {e.Message}"); }

        }

        #endregion

        #region Assertions
        [Then(@"the player should be logged in")]
        public void ThenThePlayerShouldBeLoggedIn()
        {
            try
            {
                Assert.IsTrue(_playerSessionObject.IsThePlayerLoggedIn());
            }
            catch (Exception e) { Assert.Fail($"The player can't log in to the Superbet page! {e.Message}"); }

        }

        [Then(@"the player is logged out")]
        public void ThenThePlayerIsLoggedOut()
        {
            try
            {
                Assert.IsTrue(_playerSessionObject.IsThePlayerLoggedOut());
            }
            catch (Exception e) { Assert.Fail($"The player can't logout from the Superbet page! {e.Message}"); }

        }

        #endregion
    }
}
