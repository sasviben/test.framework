using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UI.Objects;

namespace UI.Steps
{
    [Binding]
    class PlayerProfileSteps
    {
        public PlayerProfileSteps(IWebDriver webDriver)
        {
            _driver = webDriver;
            _playerSessionObject = new PlayerSessionObject(_driver);
            _navigationObject = new NavigationObject(_driver);
        }

        private readonly IWebDriver _driver;
        private readonly PlayerSessionObject _playerSessionObject;
        private readonly NavigationObject _navigationObject;


        #region Actions
        [When(@"the player tries to log in with valid credentials")]
        public void WhenThePlayerTriesToLogInWithValidCredentials()
        {
            _playerSessionObject.OpenLoginModal();
            _playerSessionObject.Login();
        }

        [Given(@"the player is logged in")]
        public void GivenThePlayerIsLoggedIn()
        {
            _navigationObject.NavigateToHomePage();
            _playerSessionObject.ExecuteLoginRequest();
        }

        [When(@"the player tries to logout")]
        public void WhenThePlayerTriesToLogout()
        {
            _playerSessionObject.Logout();
        }

        #endregion

        #region Assertions
        [Then(@"the player should be logged in")]
        public void ThenThePlayerShouldBeLoggedIn()
        {
            _playerSessionObject.IsTheUserLoggedIn();
        }

        [Then(@"the player is logged out")]
        public void ThenThePlayerIsLoggedOut()
        {
            _playerSessionObject.IsTheUserLoggedOut();
        }


        #endregion
    }
}
