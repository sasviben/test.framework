using NUnit.Framework;
using OpenQA.Selenium;
using System;
using UI.Configuration;
using UI.Helpers;
using UI.Locators;
using static UI.Helpers.Enums;

namespace UI.Objects
{
    class NavigationObject
    {
        public NavigationObject(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        private readonly IWebDriver _driver;

        #region Actions
        /// <summary>
        ///   Opens homepage
        /// </summary>
        /// <exception cref="WebDriverTimeoutException">
        ///    Fail the test if the SUPERBET logo is not visible within a specified time.
        /// </exception>
        public void NavigateToHomePage()
        {
            if (Settings.Browser.ToUpper().Equals(BrowserType.FIREFOX.ToString()))
                _driver.Navigate().GoToUrl(Settings.HomePageUrlFirefox);
            else
                _driver.Navigate().GoToUrl(Settings.HomePageUrl);

            try
            {
                _driver.WdFindElement(NavigationHeaderLOC.SuperbetLogo, 30);
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }

        }

        /// <summary>
        ///    Navigates to the desired page.
        /// </summary>
        /// <param name="pageName">
        ///    pageName represents the name of the page to navigate.
        /// </param>
        /// <exception cref="ArgumentException">
        ///    pageName is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        /// <exception cref="WebDriverTimeoutException">
        ///    Fail the test if the one or more elements are not visible in navigation header within a specified time.
        /// </exception>
        public void NavigateToPage(string pageName)
        {
            if (Enum.TryParse(pageName.Replace(" ", "_").ToUpper(), out PageType pageTypeParsed) == false)
                throw new ArgumentException($"String {pageName} can't be parsed to enum PageType!");

            try
            {
                switch (pageTypeParsed)
                {
                    case PageType.SUPERBET:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.SuperbetLogo).Click();
                            break;
                        }
                    case PageType.SPORT:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Sport).Click();
                            break;
                        }
                    case PageType.LIVE:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Live).Click();
                            break;
                        }
                    case PageType.GAMES:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Games).Click();
                            break;
                        }
                    case PageType.CASINO:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Casino).Click();
                            break;
                        }
                    case PageType.LOTTO:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Lotto).Click();
                            break;
                        }
                    case PageType.VIRTUAL:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Virtual).Click();
                            break;
                        }
                    case PageType.NEWS:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.News).Click();
                            break;
                        }
                    case PageType.RESULTS:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Results).Click();
                            break;
                        }
                    case PageType.SHOPS:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Shops).Click();
                            break;
                        }
                    case PageType.HELP:
                        {
                            _driver.WdFindElement(NavigationHeaderLOC.Help).Click();
                            break;
                        }
                    case PageType.PLAYER_ACCOUNT:
                        {
                            _driver.MoveToElement(NavigationHeaderLOC.PlayerAccount);

                            _driver.WdFindElement(PlayerMenuLOC.NavigationAccountOverview).Click();
                            break;
                        }
                    case PageType.PLAYER_TICKETS:
                        {
                            _driver.MoveToElement(NavigationHeaderLOC.PlayerAccount);

                            _driver.WdFindElement(PlayerMenuLOC.NavigationTickets).Click();
                            break;
                        }
                    case PageType.PLAYER_HISTORY:
                        {
                            _driver.MoveToElement(NavigationHeaderLOC.PlayerAccount);

                            _driver.WdFindElement(PlayerMenuLOC.NavigationTransactionsHistory).Click();
                            break;
                        }
                }

                _driver.WaitUntilElementIsInvisible(NavigationHeaderLOC.Spinner, 20);
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }
        }
        #endregion

        #region Assertions
        /// <summary>
        ///    Checks if the page is displayed.
        /// </summary>
        /// <param name="pageName">
        ///    pageName represents the name of displayed page.
        /// </param>
        /// <exception cref="ArgumentException">
        ///    pageName is a zero-length string, contains only white space, contains one or more invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        /// <exception cref="WebDriverTimeoutException">
        ///    Fail the test if the element representing opened page is not visible within a specified time.
        /// </exception>
        public void IsThePageDisplayed(string pageName)
        {
            if (!Enum.TryParse(pageName.Replace(" ", "_").ToUpper(), out PageType pageTypeParsed))
                throw new ArgumentException($"String {pageName} page can't be parsed to enum PageType!");

            try
            {
                switch (pageTypeParsed)
                {
                    case PageType.HOMEPAGE:
                        {
                            ;
                            Assert.True(_driver.WdFindElement(PrematchOfferLOC.Offer).Displayed, $"Homepage could not be opened. The element is not visible! Web element locator: {PrematchOfferLOC.Offer}.");
                            break;
                        }
                    case PageType.SPORT:
                        {
                            Assert.True(_driver.WdFindElement(PrematchOfferLOC.Offer).Displayed, $"Sport page could not be opened. The element is not visible! Web element locator: {PrematchOfferLOC.Offer}.");
                            break;
                        }
                    case PageType.LIVE:
                        {
                            Assert.True(_driver.WdFindElement(InplayOfferLOC.Offer).Displayed, $"Live page could not be opened. The element is not visible! Web element locator: {InplayOfferLOC.Offer}.");
                            break;
                        }
                    case PageType.GAMES:
                        {
                            Assert.True(_driver.WdFindElement(GamesLOC.Container).Displayed, $"Games page could not be opened. The element is not visible! Web element locator: {GamesLOC.Container}.");
                            break;
                        }
                    case PageType.CASINO:
                        {
                            Assert.True(_driver.WdFindElement(CasinoLOC.Wrapper).Displayed, $"Casino page could not be opened. The element is not visible! Web element locator: {CasinoLOC.Wrapper}.");
                            break;
                        }
                    case PageType.LOTTO:
                        {
                            Assert.True(_driver.WdFindElement(LottoOfferLOC.GridEvents).Displayed, $"Lotto page could not be opened. The element is not visible! Web element locator: {LottoOfferLOC.GridEvents}.");
                            break;
                        }
                    case PageType.VIRTUAL:
                        {
                            Assert.True(_driver.WdFindElement(VirtualLOC.Wrapper).Displayed, $"Virtual page could not be opened. The element is not visible! Web element locator: {VirtualLOC.Wrapper}");
                            break;
                        }
                    case PageType.NEWS:
                        {
                            Assert.True(_driver.WdFindElement(NewsLOC.Container).Displayed, $"News page could not be opened. The element is not visible! Web element locator: {NewsLOC.Container}");
                            break;
                        }
                    case PageType.RESULTS:
                        {
                            Assert.True(_driver.WdFindElement(ResultsLOC.Sport).Displayed, $"Results page could not be opened. The element is not visible! Web element locator: {ResultsLOC.Sport}.");
                            break;
                        }
                    case PageType.SHOPS:
                        {
                            Assert.True(_driver.WdFindElement(ShopsLOC.LayoutPage).Displayed, $"Shops page could not be opened. The element is not visible! Web element locator: {ShopsLOC.LayoutPage}.");
                            break;
                        }
                    case PageType.HELP:
                        {
                            Assert.True(_driver.WdFindElement(HelpLOC.Dropdown).Displayed, $"Help dropdown could not be opened. The element is not visible! Web element locator: {HelpLOC.Dropdown}.");
                            break;
                        }
                    case PageType.PLAYER_ACCOUNT:
                        {
                            Assert.True(_driver.WdFindElement(PlayerProfileOverviewLOC.Page).Displayed, $"Player account page could not be opened. The element is not visible! Web element locator: {PlayerProfileOverviewLOC.Page}.");
                            break;
                        }

                    case PageType.PLAYER_TICKETS:
                        {
                            Assert.True(_driver.WdFindElement(PlayerProfileTicketsLOC.Page).Displayed, $"Player tickets page could not be opened. The element is not visible! Web element locator: {PlayerProfileTicketsLOC.Page}.");
                            break;
                        }
                    case PageType.PLAYER_HISTORY:
                        {
                            Assert.True(_driver.WdFindElement(PlayerProfileTransactionsHistoryLOC.Page).Displayed, $"Player transactions history page could not be opened. The element is not visible! Web element locator: {PlayerProfileTransactionsHistoryLOC.Page}.");
                            break;
                        }
                }
            }
            catch (WebDriverTimeoutException te)
            {
                Assert.Fail(te.Message);
            }
        }
        #endregion
    }
}