using OpenQA.Selenium;
using System;
using UI.Helpers;
using UI.Locators;
using UI.Models;
using static UI.Helpers.Enums;

namespace UI.Objects
{
    class BetslipController
    {
        private readonly IWebDriver _driver;

        public BetslipController(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public bool IsBetslipEmpty()
        {
            var betslipEventCount = _driver.WdFindElement(BetslipLOC.EventsCount).WeGetAttributeValue(_driver, "innerText");
            var betslipEventCountDouble = Common.GetDoubleValueRoundedTwoDecimal(betslipEventCount);

            if (betslipEventCountDouble <= 0)
                return false;
            return true;

        }
        public void SelectTicketOptions(string ticketSessionType, string ticketCombinationType, bool isSport = true)
        {

            if (Enum.TryParse(ticketSessionType, true, out BetslipType ticketTypeParsed) == false)
                throw new ArgumentException($"String {ticketSessionType} can't be parsed to enum BetslipType!");

            if (Enum.TryParse(ticketCombinationType, true, out BetslipType ticketCombinationTypeParsed) == false)
                throw new ArgumentException($"String {ticketCombinationType} can't be parsed to enum BetslipType!");

            if (ticketTypeParsed.Equals(BetslipType.ONLINE))
                _driver.WdFindElement(BetslipLOC.ButtonOnlineTicket).Click();
            else if (ticketTypeParsed.Equals(BetslipType.AGENCY))
                _driver.WdFindElement(BetslipLOC.ButtonAgencyTicket).Click();

            if (isSport)
            {
                if (ticketCombinationTypeParsed.Equals(BetslipType.SIMPLE))
                    _driver.WdFindElement(BetslipLOC.ButtonSimpleTicket).Click();
                else if (ticketCombinationTypeParsed.Equals(BetslipType.SYSTEM))
                    _driver.WdFindElement(BetslipLOC.ButtonSystemTicket).Click();
            }

            BetslipModel.Stake = Common.GetRandomNumber(2, 20);
            var ticketStakeField = _driver.WdFindElement(BetslipLOC.InputFieldStake);
            ticketStakeField.Clear();
            ticketStakeField.SendKeys(BetslipModel.Stake.ToString());

        }

    }
}
