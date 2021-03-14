using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
        private const string URL_INPLAY = "LIVE";
        private const string SPORT_INPLAY = "INPLAY";
        private const string SPORT_PREMATCH = "PREMATCH";

        public SportBettingObject(IWebDriver webDriver)
        {
            _driver = webDriver;
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
                        AddRandomSportSelectionsToBetslip(1, SPORT_INPLAY);
                    }
                    else
                    {
                        dirtyEvent.WeFindElement(_driver, BetslipLOC.ButtonDeleteEvent).Click();
                        new NavigationObject(_driver).NavigateToSportPage(SPORT_PREMATCH);
                        AddRandomSportSelectionsToBetslip(1, SPORT_PREMATCH);
                    }
                }
            }

        }

        #region Actions

        public void AddRandomSportSelectionsToBetslip(int numberOfEventsToAdd, string bettingType)
        {
            if (Enum.TryParse(bettingType, true, out SportBettingType sportBettingType) == false)
                throw new ArgumentException($"String {bettingType} can't be parsed to enum SportBettingType!");

            var selections = new List<IWebElement>();
            if (sportBettingType.Equals(SportBettingType.SPECIAL))
            {
                throw new NotImplementedException("Special betting is not supported yet!");
            }
            else
            {

                var offer = new Dictionary<IWebElement, List<IWebElement>>(); //key:event row, value: odds

                var eventRows = _driver.WdFindElements(SportOfferLOC.Matches).ToList();
                foreach (var row in eventRows)
                {

                    selections = row.WeFindElements(_driver, SportEventLOC.OddValue).OrderBy(x => Guid.NewGuid()).ToList();
                    if (selections.Count > 0)
                        offer.Add(row, selections);

                }

                if (offer.Count < numberOfEventsToAdd)
                    throw new Exception($"Can't add {numberOfEventsToAdd} selections on the Betslip because there are only {offer.Count} selections available!");

                foreach (var row in offer)
                {
                    var selection = row.Value[0];
                    selection.WeMoveToElement(_driver);

                    var oddValueDouble = Common.GetDoubleValueRoundedTwoDecimal(selection.WeGetAttributeValue(_driver, "innerText"));
                    if (oddValueDouble >= 1.01)
                    {
                        if (selection.WeIsElementClickable(_driver, 2))
                            selection.Click();

                        var numberOfEventsOnTheBetslip = int.Parse(_driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText"));
                        if (numberOfEventsOnTheBetslip == numberOfEventsToAdd)
                            break;
                    }
                }

            }
        }

        public void PurchaseSportTicket()
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

            if (_driver.WdIsElementVisible(BetslipLOC.ValidationMessage, 2))
                throw new Exception($"Betslip contans error message: {_driver.WdFindElement(BetslipLOC.ValidationMessage).WeGetAttributeValue(_driver, "innerText")}");

            _driver.WaitUntilElementIsInvisible(BetslipLOC.Spinner, 30);

            if (_driver.WdIsElementVisible(BetslipLOC.ValidationMessage, 2))
                throw new Exception($"Betslip contans error message: {_driver.WdFindElement(BetslipLOC.ValidationMessage).WeGetAttributeValue(_driver, "innerText")}");

            PlayerProfileModel.BalanceAfterPurchase = CookieManager.GetPlayerBalance();

        }
        #endregion

        #region Assertions
        
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
