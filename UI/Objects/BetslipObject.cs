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
    class BetslipObject
    {
        public BetslipObject(IWebDriver webDriver)
        {
            _driver = webDriver;
            _playerSessionObject = new PlayerSessionObject(_driver);
        }

        private readonly IWebDriver _driver;
        private readonly PlayerSessionObject _playerSessionObject;
        private const string URL_INPLAY = "LIVE";
        private const string SPORT_INPLAY = "INPLAY";
        private const string SPORT_PREMATCH = "PREMATCH";

        /// <summary>
        ///    Finds event with validation message and replaces it with the new one.
        /// </summary>
        private void ReplaceDirtyEvent()
        {

            var betslipEvents = _driver.WdFindElements(BetslipLOC.RowEvent);

            foreach (var dirtyEvent in betslipEvents)
            {
                if (dirtyEvent.WeIsElementVisible(_driver, BetslipLOC.EventValidationMessage))
                {
                    if (dirtyEvent.WeIsElementVisible(_driver, SportEventLOC.LiveIndicator))
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

        /// <summary>
        ///    Add random Sport events to the Betslip.
        /// </summary>
        /// <param name="numberOfEventsToAdd">
        ///    Number of random Sport events to add.
        /// </param>
        /// <param name="bettingType">
        ///    Type of Sport events to add. Can be Prematch, Inplay and Special.
        /// </param>
        /// <exception cref="ArgumentException">
        ///    bettingType is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        public void AddSportEvents(int numberOfEventsToAdd, string bettingType)
        {
            var random = new Random();

            if (Enum.TryParse(bettingType, true, out SportBettingType sportBettingType) == false)
                throw new ArgumentException($"String {bettingType} can't be parsed to enum SportBettingType!");

            if (sportBettingType.Equals(SportBettingType.SPECIAL))
            {
                //todo
                throw new NotImplementedException("Special betting is not supported yet!");
            }
            else
            {
                var eventsTemp = _driver.WdFindElements(SportOfferLOC.Matches);
                var eventsListLength = eventsTemp.Count;

                if (eventsListLength < numberOfEventsToAdd)
                    numberOfEventsToAdd = eventsListLength;

                while (numberOfEventsToAdd != 0)
                {
                    var randomEvent = eventsTemp[random.Next(eventsListLength)];
                    randomEvent.WeMoveToElement(_driver);
                    randomEvent.WeHighlightElement(_driver);

                    var odd = randomEvent.WeFindElement(_driver, SportEventLOC.ContainerOdd);
                    if (odd != null)
                    {
                        var oddValue = randomEvent.WeFindElements(_driver, SportEventLOC.OddValue).FirstOrDefault();

                        var oddValueDouble = Common.GetDoubleValueRoundedTwoDecimal(oddValue.WeGetAttributeValue(_driver, "innerText"));
                        if (oddValueDouble >= 1.01)
                        {
                            odd.Click();
                            numberOfEventsToAdd--;
                        }
                    }
                }
            }

        }

        /// <summary>
        ///    Purchases a ticket.
        /// </summary>
        public void PurchaseTicket()
        {

            var currentTime = DateTime.Now;
            var exceedTime = currentTime.AddSeconds(300); //5min

            while (currentTime < exceedTime)
            {
                if (_driver.WdIsElementVisible(BetslipLOC.EventValidationMessage, 1))
                    ReplaceDirtyEvent();
                

                _driver.WdFindElement(BetslipLOC.ButtonPurchase).Click();

                if (_driver.WdIsElementVisible(BetslipLOC.Spinner, 1))
                {
                    _driver.WaitUntilElementIsInvisible(BetslipLOC.Spinner, 30);
                    break;
                }

                currentTime = DateTime.Now;
            }
            if (_driver.WdIsElementVisible(BetslipLOC.ValidationMessage, 1))
                BetslipModel.ValidationMessage = _driver.WdFindElement(BetslipLOC.ValidationMessage).WeGetAttributeValue(_driver, "innerText");

            if (PlayerProfileModel.BalanceAfterLogin > 0)
                PlayerProfileModel.BalanceAfterPurchase = CookieManager.GetPlayerBalance();

        }

        /// <summary>
        ///    Selects ticket options on the Betslip.
        /// </summary>
        /// <param name="ticketType">
        ///    Represents Online or Agency ticket type.
        /// </param>
        /// <param name="ticketCombinationType">
        ///    Represents Simple or System ticket type.
        /// </param>
        /// <exception cref="ArgumentException">
        ///    ticketType or ticketCombinationType is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        public void SelectTicketOptions(string ticketType, string ticketCombinationType)
        {
            if (Enum.TryParse(ticketType, true, out BetslipType ticketTypeParsed) == false)
                throw new ArgumentException($"String {ticketType} can't be parsed to enum BetslipType!");

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

        }

        #endregion

        #region Assertions
        /// <summary>
        ///    Checks if Betslip is empty.
        /// </summary>
        /// <returns>
        ///    True if Betslip component contains sport events or lotto numbers, else returns false.
        /// </returns>
        public bool IsBetslipEmpty()
        {
            var betslipEventCount = _driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText");
            var betslipEventCountDouble = Common.GetDoubleValueRoundedTwoDecimal(betslipEventCount);

            if (betslipEventCountDouble <= 0)
                return false;
            return true;

        }
        #endregion

    }
}
