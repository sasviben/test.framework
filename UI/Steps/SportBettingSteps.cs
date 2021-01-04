using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UI.Objects;
using static UI.Helpers.Enums;

namespace UI.Steps
{
    [Binding]
    class SportBettingSteps
    {
        public SportBettingSteps(IWebDriver webDriver)
        {
            _driver = webDriver;
            _navigationObject = new NavigationObject(_driver);
            _sportBettingObject = new SportBettingObject(_driver);
        }

        private readonly IWebDriver _driver;
        private readonly NavigationObject _navigationObject;
        private readonly SportBettingObject _sportBettingObject;

        #region Actions
        [Given(@"the player has added ""(.*)"" random ""(.*)"" ""(.*)"" events to the Betslip")]
        public void GivenThePlayerHasAddedRandomEventsToTheBetslip(int numberOfEventsToAdd, string bettingType, string sportGame)
        {

            if (bettingType.ToUpper().Equals(SportBettingType.PREMATCH.ToString()))
            {
                _navigationObject.NavigateToSportPage(bettingType);
                _navigationObject.NavigateToSportGame(sportGame);
            }
            else if (bettingType.ToUpper().Equals(SportBettingType.INPLAY.ToString()))
            {
                _navigationObject.NavigateToSportPage(bettingType);
                _navigationObject.NavigateToSportGame(sportGame);
            }
            else if (bettingType.ToUpper().Equals(SportBettingType.SPECIAL.ToString()))
                _navigationObject.NavigateToSportPage(bettingType);

            _sportBettingObject.AddToTheBetslip(numberOfEventsToAdd, bettingType);


        }

    }

    #endregion
}
