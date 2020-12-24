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
            _login = new LoginObject(_driver);
        }

        private readonly IWebDriver _driver;
        private readonly LoginObject _login;


        #region Actions
        [When(@"the player tries to log in with valid credentials")]
        public void WhenThePlayerTriesToLogInWithValidCredentials()
        {
            _login.OpenLoginModal();
            _login.Login();
        }

        #endregion

        #region Assertions
        [Then(@"the player should be logged in")]
        public void ThenThePlayerShouldBeLoggedIn()
        {
            _login.IsTheUserLoggedIn();
        }

        #endregion
    }
}
