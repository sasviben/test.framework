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
    class LottoBettingObject
    {
        private readonly IWebDriver _driver;

        public LottoBettingObject(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        #region Actions
        public void AddLottoSelectionsToBetslip(int numberOfEventsToAdd)
        {
            //pick event with start time greater than current time + 3 minutes
            var availableLottoOffer = _driver.WdFindElements(LottoLOC.RowEvent);
            var currentTime = DateTime.Now.AddMinutes(3.00).TimeOfDay.TotalMinutes;

            if (availableLottoOffer.Count <= 0)
                throw new Exception("Lotto offer isn't available!");

            foreach (var lottoEvent in availableLottoOffer)
            {
                var lottoEventTime = lottoEvent.WeFindElement(_driver, LottoLOC.LottoEventDateTime).WeGetAttributeValue(_driver, "innerText").Split(" ");
                var time = TimeSpan.Parse(lottoEventTime[1]).TotalMinutes;

                if (time >= currentTime)
                {
                    lottoEvent.Click();
                    break;
                }
            }

            if (numberOfEventsToAdd == 5)
                _driver.WdFindElement(LottoLOC.OptionRarestFiveNumbers).Click();
            else
            {
                var shuffledLottoBalls = _driver.WdFindElements(LottoLOC.GridBall).OrderBy(x => Guid.NewGuid()).ToList();
                foreach (var ball in shuffledLottoBalls)
                {
                    if (ball.WeIsElementClickable(_driver, 2))
                        ball.Click();

                    var numberOfEventsOnTheBetslip = int.Parse(_driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText"));
                    if (numberOfEventsOnTheBetslip == numberOfEventsToAdd)
                        break;
                }
            }

        }

        public void PurchaseLottoTicket()
        {
            _driver.WdFindElement(BetslipLOC.ButtonPurchase).Click();

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
                    StringAssert.AreEqualIgnoringCase(expected: "LOTTO", actual: bettingTypeActual, $"Widget betting type is not equal to the LOTTO!");
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
