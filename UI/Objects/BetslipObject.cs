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
        /// <exception cref="WebDriverTimeoutException">
        ///    Webdriver can't find one or more events within a specified time.
        /// </exception>
        private void ReplaceDirtyEvent()
        {
            try
            {
                var betslipEvents = _driver.WdFindElements(BetslipLOC.RowEvent);

                foreach (var dirtyEvent in betslipEvents)
                {
                    if (dirtyEvent.WeFindElement(_driver, BetslipLOC.EventValidationMessage).Displayed)
                    {
                        if (dirtyEvent.WeFindElement(_driver, SportEventLOC.LiveIndicator).Displayed)
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
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverTimeoutException(te.Message);
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
        /// <exception cref="WebDriverTimeoutException">
        ///    Webdriver can't find one or more events in the Sport offer within a specified time.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///    bettingType is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        public void AddSportEvents(int numberOfEventsToAdd, string bettingType)
        {
            var random = new Random();

            if (Enum.TryParse(bettingType, true, out SportBettingType sportBettingType) == false)
                throw new ArgumentException($"String {bettingType} can't be parsed to enum SportBettingType!");

            try
            {
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
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverTimeoutException(te.Message);
            }

        }

        /// <summary>
        ///    Purchases a ticket.
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///    Webdriver can't find one or more Betslip elements within a specified time.
        /// </exception>
        public void PurchaseTicket()
        {
            try
            {
                var currentTime = DateTime.Now;
                var exceedTime = currentTime.AddSeconds(300); //5min

                while (currentTime < exceedTime)
                {
                    if (_driver.WdFindElement(BetslipLOC.EventValidationMessage, 1).Displayed)//ako postoji validacijska poruka
                        ReplaceDirtyEvent();

                    _driver.WdFindElement(BetslipLOC.ButtonPurchase).Click();

                    if (_driver.WdFindElement(BetslipLOC.Spinner, 1).Displayed)
                    {
                        _driver.WaitUntilElementIsInvisible(BetslipLOC.Spinner, 30);
                        break;
                    }

                    currentTime = DateTime.Now;
                }
                if (_driver.WdFindElement(BetslipLOC.ValidationMessage).Displayed)
                    BetslipModel.ValidationMessage = _driver.WdFindElement(BetslipLOC.ValidationMessage).WeGetAttributeValue(_driver, "innerText");

                if (PlayerProfileModel.BalanceAfterLogin > 0)
                    PlayerProfileModel.BalanceAfterPurchase = CookieManager.GetPlayerBalance();
            }
            catch (WebDriverException te)
            {
                throw new WebDriverException(te.Message);
            }

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
        /// <exception cref="WebDriverTimeoutException">
        ///    Web driver can not find one or more elements on the Betslip within a specified time.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///    ticketType or ticketCombinationType is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        public void SelectTicketOptions(string ticketType, string ticketCombinationType)
        {
            if (Enum.TryParse(ticketType, true, out BetslipType ticketTypeParsed) == false)
                throw new ArgumentException($"String {ticketType} can't be parsed to enum BetslipType!");

            if (Enum.TryParse(ticketCombinationType, true, out BetslipType ticketCombinationTypeParsed) == false)
                throw new ArgumentException($"String {ticketCombinationType} can't be parsed to enum BetslipType!");

            try
            {
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
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverException(te.Message);
            }

        }

        #endregion

        #region Assertions
        /// <summary>
        ///    Checks if Betslip is empty.
        /// </summary>
        /// <returns>
        ///    True if Betslip component contains sport events or lotto numbers, else returns false.
        /// </returns>
        /// <exception cref="WebDriverTimeoutException">
        ///    Web driver can not find the Betslip event counter within a specified time.
        /// <exception cref="ArgumentException">
        ///    stringValue is a zero-length string, contains only white space, contains one or more invalid characters.
        /// </exception>
        public bool IsBetslipEmpty()
        {
            try
            {
                var betslipEventCount = _driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText");
                var betslipEventCountDouble = Common.GetDoubleValueRoundedTwoDecimal(betslipEventCount);

                if (betslipEventCountDouble <= 0)
                    return false;
            }
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverException(te.Message);
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException(ae.Message);
            }

            return true;

        }
        #endregion

    }
}
