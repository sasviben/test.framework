using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using UI.Backend.Clients;
using UI.Helpers;
using UI.Locators;
using UI.Models;
using static UI.Helpers.Enums;

namespace UI.Objects
{
    class SportBettingObject
    {

        private readonly IWebDriver _driver;
        private readonly PlayerSessionObject _playerSessionObject;
        private const string URL_INPLAY = "LIVE";
        private const string SPORT_INPLAY = "INPLAY";
        private const string SPORT_PREMATCH = "PREMATCH";

        public SportBettingObject(IWebDriver webDriver)
        {
            _driver = webDriver;
            _playerSessionObject = new PlayerSessionObject(_driver);
        }


        private void ReplaceDirtyEvent()
        {

            var betslipEvents = _driver.WdFindElements(BetslipLOC.RowEvent);

            foreach (var dirtyEvent in betslipEvents)
            {
                if (dirtyEvent.WeIsElementVisible(_driver, BetslipLOC.EventValidationMessage, 1))
                {
                    if (dirtyEvent.WeIsElementVisible(_driver, SportEventLOC.LiveIndicator, 1))
                    {
                        dirtyEvent.WeFindElement(_driver, BetslipLOC.ButtonDeleteEvent).Click();
                        if (!_driver.Url.Contains(URL_INPLAY))
                            new NavigationObject(_driver).NavigateToSportPage(SPORT_INPLAY);
                        AddSportEvents(1, SPORT_INPLAY);
                    }
                    else
                    {
                        dirtyEvent.WeFindElement(_driver, BetslipLOC.ButtonDeleteEvent).Click();
                        new NavigationObject(_driver).NavigateToSportPage(SPORT_PREMATCH);
                        AddSportEvents(1, SPORT_PREMATCH);
                    }
                }
            }

        }

        #region Actions

        public void AddSportEvents(int numberOfEventsToAdd, string bettingType)
        {
            var random = new Random();
            var numberOfEventsOnTheBetslip = 0;

            if (Enum.TryParse(bettingType, true, out SportBettingType sportBettingType) == false)
                throw new ArgumentException($"String {bettingType} can't be parsed to enum SportBettingType!");

            if (sportBettingType.Equals(SportBettingType.SPECIAL))
            {
                throw new NotImplementedException("Special betting is not supported yet!");
            }
            else
            {
                var eventsTemp = _driver.WdFindElements(SportOfferLOC.Matches);
                var eventsListLength = eventsTemp.Count;

                if (eventsListLength < numberOfEventsToAdd)
                    throw new Exception($"Can't add {numberOfEventsToAdd} selections on the Betslip because there are only {eventsListLength} selections available!");

                while (numberOfEventsToAdd != 0)
                {
                    var randomEvent = eventsTemp[random.Next(eventsListLength)];
                    randomEvent.WeMoveToElement(_driver);

                    if (randomEvent.Displayed)
                        randomEvent.WeHighlightElement(_driver);

                    var odd = randomEvent.WeFindElement(_driver, SportEventLOC.ContainerOdd);
                    if (odd != null)
                    {
                        var oddValue = randomEvent.WeFindElements(_driver, SportEventLOC.OddValue).FirstOrDefault();

                        var oddValueDouble = Common.GetDoubleValueRoundedTwoDecimal(oddValue.WeGetAttributeValue(_driver, "innerText"));
                        if (oddValueDouble >= 1.01)
                        {
                            odd.Click();

                            var numberOfEventsOnTheBetslipTemp = int.Parse(_driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText"));

                            if (numberOfEventsOnTheBetslipTemp > numberOfEventsOnTheBetslip)
                            {
                                numberOfEventsOnTheBetslip = numberOfEventsOnTheBetslipTemp;
                                numberOfEventsToAdd--;
                            }

                        }
                    }
                }
            }

        }

        public void PurchaseTicket()
        {

            var currentTime = DateTime.Now;
            var exceedTime = currentTime.AddSeconds(300); //5min

            while (currentTime < exceedTime)
            {
                if (_driver.WdIsElementVisible(BetslipLOC.EventValidationMessage, 1))
                    ReplaceDirtyEvent();


                _driver.WdFindElement(BetslipLOC.ButtonPurchase).Click();

                if (_driver.WdIsElementVisible(BetslipLOC.Spinner))
                    break;

                currentTime = DateTime.Now;
            }

            if (_driver.WdIsElementVisible(BetslipLOC.ValidationMessage, 1))
                BetslipModel.ValidationMessage = _driver.WdFindElement(BetslipLOC.ValidationMessage).WeGetAttributeValue(_driver, "innerText");
            _driver.WaitUntilElementIsInvisible(BetslipLOC.Spinner, 1);
            if (_driver.WdIsElementVisible(BetslipLOC.ValidationMessage, 1))
                BetslipModel.ValidationMessage = _driver.WdFindElement(BetslipLOC.ValidationMessage).WeGetAttributeValue(_driver, "innerText");

            PlayerProfileModel.BalanceAfterPurchase = CookieManager.GetPlayerBalance();

        }

        public void SelectTicketOptions(string ticketSessionType, string ticketCombinationType)
        {

            if (Enum.TryParse(ticketSessionType, true, out BetslipType ticketTypeParsed) == false)
                throw new ArgumentException($"String {ticketSessionType} can't be parsed to enum BetslipType!");

            if (Enum.TryParse(ticketCombinationType, true, out BetslipType ticketCombinationTypeParsed) == false)
                throw new ArgumentException($"String {ticketCombinationType} can't be parsed to enum BetslipType!");

            if (ticketTypeParsed.Equals(BetslipType.ONLINE))
            {
                if (_playerSessionObject.IsThePlayerLoggedIn())
                    _driver.WdFindElement(BetslipLOC.ButtonOnlineTicket).Click();
            }
            else if (ticketTypeParsed.Equals(BetslipType.AGENCY))
                _driver.WdFindElement(BetslipLOC.ButtonAgencyTicket).Click();

            if (ticketCombinationTypeParsed.Equals(BetslipType.SIMPLE))
                _driver.WdFindElement(BetslipLOC.ButtonSimpleTicket).Click();
            else if (ticketCombinationTypeParsed.Equals(BetslipType.SYSTEM))
                _driver.WdFindElement(BetslipLOC.ButtonSystemTicket).Click();

            BetslipModel.Stake = Common.GetRandomNumber(2, 20);

            var ticketStakeField = _driver.WdFindElement(BetslipLOC.InputFieldStake);
            ticketStakeField.Clear();
            ticketStakeField.SendKeys(BetslipModel.Stake.ToString());

        }

        #endregion

        #region Assertions
        public bool IsBetslipEmpty()
        {
            var betslipEventCount = _driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText");
            var betslipEventCountDouble = Common.GetDoubleValueRoundedTwoDecimal(betslipEventCount);

            if (betslipEventCountDouble <= 0)
                return false;
            return true;

        }

        public void TicketWidgetWithCorrectDataIsDisplayed(string ticketSessionType, string ticketCombinationType)
        {
            if (Enum.TryParse(ticketSessionType, true, out BetslipType ticketSessionTypeParsed) == false)
                throw new ArgumentException($"String {ticketSessionType} can't be parsed to enum BetslipType!");

            if (ticketSessionTypeParsed.Equals(BetslipType.ONLINE))
            {
                var widgetTitle = _driver.WdFindElement(WidgetLOC.Title).WeGetAttributeValue(_driver, "innerText").Trim().Split("\r");

                var bettingTypeActual = Common.TranslateToEnglish(widgetTitle[0]);
                var ticketCombinationTypeActual = Common.TranslateToEnglish(widgetTitle[1].Remove(0, 1));
                var ticketId = widgetTitle[2].Remove(0, 1);

                Assert.Multiple(() =>
                {
                    StringAssert.AreEqualIgnoringCase(expected: "SPORT", actual: bettingTypeActual, $"Widget betting type is not equal to the SPORT!");
                    StringAssert.AreEqualIgnoringCase(expected: ticketCombinationType, actual: ticketCombinationTypeActual, $"Widget ticket type is not equal to the {ticketCombinationType} !");
                    Assert.IsNotEmpty(ticketId, $"Ticket ID ({ticketId}) is missing on the ticket widget!");
                });
            }
            else if (ticketSessionTypeParsed.Equals(BetslipType.AGENCY))
            {
                throw new NotImplementedException();
            }

        }
        #endregion

    }
}
