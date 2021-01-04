using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.Helpers;
using UI.Locators;
using static UI.Helpers.Enums;

namespace UI.ModelControllers
{
    class OfferController
    {
        public OfferController(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        private readonly IWebDriver _driver;

        /// <summary>
        ///    Gets random events from Sport offer.
        /// </summary>
        /// <param name="eventsNumber">
        ///    Number of random events to get.
        /// </param>
        /// <param name="bettingType">
        ///    Sport betting type. Can be Prematch, Inplay and Special.
        /// </param>
        /// <returns>
        ///    List of random IWebElement types.
        /// </returns>
        /// <exception cref="WebDriverTimeoutException">
        ///    One or more events are not visible in Sport offer within a specified time.
        /// </exception>
        public List<IWebElement> GetEventsFromSportOffer(int eventsNumber, string bettingType)
        {
            var _events = new List<IWebElement>();
            var random = new Random();
            try
            {
                if (bettingType.Equals(SportBettingType.SPECIAL))
                {
                    //todo
                    throw new NotImplementedException("Special betting is not supported yet!");
                }
                else
                {
                    var eventsTemp = _driver.WdFindElements(SportOfferLOC.Matches);
                    var eventsListLength = eventsTemp.Count;

                    if (eventsListLength < eventsNumber)
                        eventsNumber = eventsListLength;

                    while (_events.Count != eventsNumber)
                    {
                        var randomEvent = eventsTemp[random.Next(eventsListLength)];
                        randomEvent.WeHighlightElement(_driver);

                        if (randomEvent.WeFindElement(_driver, SportEventLOC.ContainerOdd) != null)
                        {
                            var oddValue = randomEvent.WeFindElements(_driver, SportEventLOC.OddValue).FirstOrDefault();

                            var oddValueDouble = Common.GetDoubleValueRoundedTwoDecimal(oddValue.WeGetAttributeValue(_driver, "innerText"));
                            if (oddValueDouble >= 1.01)
                                _events.Add(randomEvent);
                        }
                    }
                }

            }
            catch (WebDriverTimeoutException te)
            {
                throw new WebDriverTimeoutException(te.Message);
            }

            return _events;

        }
    }
}
