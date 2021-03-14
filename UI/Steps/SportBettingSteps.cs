using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UI.Objects;

namespace UI.Steps
{
    [Binding]
    class SportBettingSteps
    {
        private const string PREMATCH = "PREMATCH";
        private const string INPLAY = "INPLAY";
        private const string SPECIAL = "SPECIAL";
        private readonly IWebDriver _driver;
        private readonly NavigationObject _navigationObject;
        private readonly SportBettingObject _sportBettingObject;
        private readonly BetslipController _betslipController;

        public SportBettingSteps(IWebDriver webDriver)
        {
            _driver = webDriver;
            _navigationObject = new NavigationObject(_driver);
            _sportBettingObject = new SportBettingObject(_driver);
            _betslipController = new BetslipController(_driver);
        }

        #region Actions
        [Given(@"the player has added ""(.*)"" random ""(.*)"" ""(.*)"" events to the Betslip")]
        public void GivenThePlayerHasAddedRandomEventsToTheBetslip(int numberOfEventsToAdd, string bettingType, string sportGame)
        {
            if (numberOfEventsToAdd <= 0)
                Assert.Fail("Number of events to add must be greater than zero!");
            if (string.IsNullOrEmpty(bettingType))
                Assert.Fail("String bettingType is null or empty!");
            if (string.IsNullOrEmpty(sportGame))
                Assert.Fail("String sportGame is null or empty!");

            try
            {
                if (bettingType.Equals(PREMATCH, StringComparison.OrdinalIgnoreCase))
                {
                    _navigationObject.NavigateToSportPage(bettingType);
                    _navigationObject.NavigateToSportGame(sportGame);
                }
                else if (bettingType.Equals(INPLAY, StringComparison.OrdinalIgnoreCase))
                {
                    _navigationObject.NavigateToSportPage(bettingType);
                    _navigationObject.NavigateToSportGame(sportGame);
                }
                else if (bettingType.Equals(SPECIAL, StringComparison.OrdinalIgnoreCase))
                    _navigationObject.NavigateToSportPage(bettingType);

                _sportBettingObject.AddRandomSportSelectionsToBetslip(numberOfEventsToAdd, bettingType);
            }
            catch (Exception e)
            {
                Assert.Fail($"Step 'the player has added {numberOfEventsToAdd} random {bettingType} {sportGame} events to the Betslip' failed! {e.Message}");
            }

        }

        [When(@"the player purchases an ""(.*)"" sport ""(.*)"" ticket")]
        public void WhenThePlayerPurchasesAnTicket(string ticketSessionType, string ticketCombinationType)
        {
            if (string.IsNullOrEmpty(ticketSessionType))
                Assert.Fail("String ticketType is null or empty!");
            if (string.IsNullOrEmpty(ticketCombinationType))
                Assert.Fail("String ticketCombinationType is null or empty!");

            try
            {
                Assert.IsTrue(_betslipController.IsBetslipEmpty(), "Sport Betslip does not contain any sport events!");

                _betslipController.SelectTicketOptions(ticketSessionType, ticketCombinationType);
                _sportBettingObject.PurchaseSportTicket();
            }
            catch (Exception e) { Assert.Fail($"Step 'the player purchases an {ticketSessionType} sport {ticketCombinationType} ticket' failed! {e.Message}"); }

        }
        #endregion

        #region Assertions
        [Then(@"the ""(.*)"" sport ""(.*)"" ticket is purchased")]
        public void ThenTheTicketIsPurchased(string ticketSessionType, string ticketCombinationType)
        {
            try
            {
                _sportBettingObject.TicketWidgetWithCorrectDataIsDisplayed(ticketSessionType, ticketCombinationType);
            }
            catch (Exception e) { Assert.Fail($"Step 'the {ticketSessionType} sport {ticketCombinationType} ticket is purchased' failed! {e.Message}"); }

        }
        #endregion
    }
}
