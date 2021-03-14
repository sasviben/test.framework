using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UI.Objects;

namespace UI.Steps
{
    [Binding]
    class LottoBettingSteps
    {
        private const string LOTTO = "LOTTO";
        private readonly IWebDriver _driver;
        private readonly NavigationObject _navigationObject;
        private readonly LottoBettingObject _lottoBettingObject;
        private readonly BetslipController _betslipController;


        public LottoBettingSteps(IWebDriver webDriver)
        {
            _driver = webDriver;
            _navigationObject = new NavigationObject(_driver);
            _lottoBettingObject = new LottoBettingObject(_driver);
            _betslipController = new BetslipController(_driver);
        }

        #region Actions
        [Given(@"the player has added ""(.*)"" Lotto selection to the Betslip")]
        public void GivenThePlayerHasAddedLottoSelectionToTheBetslip(int numberOfEventsToAdd)
        {
            if (numberOfEventsToAdd <= 0)
                Assert.Fail("Number of events to add must be greater than zero!");

            try
            {
                _navigationObject.NavigateToMainPage(LOTTO);
                _lottoBettingObject.AddLottoSelectionsToBetslip(numberOfEventsToAdd);
            }
            catch (Exception e)
            {
                Assert.Fail($"Step 'the player has added {numberOfEventsToAdd} Lotto selection to the Betslip' failed! {e.Message}");
            }

        }

        [When(@"the player purchases an ""(.*)"" Lotto ""(.*)"" ticket")]
        public void WhenThePlayerPurchasesAnLottoTicket(string ticketSessionType, string ticketCombinationType)
        {
            if (string.IsNullOrEmpty(ticketSessionType))
                Assert.Fail("String ticketType is null or empty!");
            if (string.IsNullOrEmpty(ticketCombinationType))
                Assert.Fail("String ticketCombinationType is null or empty!");

            try
            {
                Assert.IsTrue(_betslipController.IsBetslipEmpty(), "Lotto Betslip does not contain any lotto selections!");

                _betslipController.SelectTicketOptions(ticketSessionType, ticketCombinationType, false);
                _lottoBettingObject.PurchaseLottoTicket();
            }
            catch (Exception e) { Assert.Fail($"Step 'the player purchases an {ticketSessionType} lotto {ticketCombinationType} ticket' failed! {e.Message}"); }
        }


        #endregion

        #region Assertions
        [Then(@"the ""(.*)"" Lotto ""(.*)"" ticket is purchased")]
        public void ThenTheLottoTicketIsPurchased(string ticketSessionType, string ticketCombinationType)
        {
            try
            {
                _lottoBettingObject.TicketWidgetWithCorrectDataIsDisplayed(ticketSessionType, ticketCombinationType);
            }
            catch (Exception e) { Assert.Fail($"Step 'the {ticketSessionType} sport {ticketCombinationType} ticket is purchased' failed! {e.Message}"); }

        }

        #endregion
    }
}
