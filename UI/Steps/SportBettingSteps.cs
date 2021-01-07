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
        public SportBettingSteps(IWebDriver webDriver)
        {
            _driver = webDriver;
            _navigationObject = new NavigationObject(_driver);
            _betslipObject = new BetslipObject(_driver);
        }

        private const string SPORT = "SPORT";
        private const string LOTTO = "LOTTO";
        private const string PREMATCH = "PREMATCH";
        private const string INPLAY = "INPLAY";
        private const string SPECIAL = "SPECIAL";
        private readonly IWebDriver _driver;
        private readonly NavigationObject _navigationObject;
        private readonly BetslipObject _betslipObject;

        #region Actions
        [Given(@"the player has added ""(.*)"" random ""(.*)"" ""(.*)"" events to the Betslip")]
        public void GivenThePlayerHasAddedRandomEventsToTheBetslip(int numberOfEventsToAdd, string bettingType, string sportGame)
        {
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

                _betslipObject.AddSportEvents(numberOfEventsToAdd, bettingType);
            }
            catch (Exception e) { Assert.Fail($"Step 'the player has added {numberOfEventsToAdd} random {bettingType} {sportGame} events to the Betslip' failed! {e.Message}"); }

        }

        [When(@"the player purchases an ""(.*)"" ""(.*)"" ""(.*)"" ticket")]
        public void WhenThePlayerPurchasesAnTicket(string ticketType, string bettingType, string ticketCombinationType)
        {
            if (string.IsNullOrEmpty(ticketType))
                Assert.Fail("String ticketType is null or empty!");
            if (string.IsNullOrEmpty(bettingType))
                Assert.Fail("String bettingType is null or empty!");
            if (string.IsNullOrEmpty(ticketCombinationType))
                Assert.Fail("String ticketCombinationType is null or empty!");

            try
            {
                if (bettingType.Equals(SPORT, StringComparison.OrdinalIgnoreCase))
                {
                    Assert.IsTrue(_betslipObject.IsBetslipEmpty(), "Sport Betslip does not contain any sport events!");

                    _betslipObject.SelectTicketOptions(ticketType, ticketCombinationType);
                    _betslipObject.PurchaseTicket();
                }

                if (bettingType.Equals(LOTTO, StringComparison.OrdinalIgnoreCase))
                {
                    Assert.IsTrue(_betslipObject.IsBetslipEmpty(), "Lotto Betslip does not contain any lotto numbers!");

                    _betslipObject.SelectTicketOptions(ticketType, ticketCombinationType);
                    _betslipObject.PurchaseTicket();
                }
            }
            catch (Exception e) { Assert.Fail($"Step 'the player purchases an {ticketType} {bettingType} {ticketCombinationType} ticket' failed! {e.Message}"); }

        }

    }

    #endregion
}
