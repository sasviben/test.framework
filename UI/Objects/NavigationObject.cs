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

        private readonly IWebDriver _driver;
        public NavigationObject(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        #region Actions

        public void NavigateToHomePage()
        {
            if (Enum.TryParse(Settings.Browser, true, out BrowserType browserType) == false)
                throw new ArgumentException($"String {Settings.Browser} can't be parsed to enum BrowserType!");

            if (browserType.Equals(BrowserType.FIREFOX))
                _driver.Navigate().GoToUrl(Settings.HomePageUrlFirefox);
            else
                _driver.Navigate().GoToUrl(Settings.HomePageUrl);

        }

        public void NavigateToMainPage(string pageName)
        {
            if (Enum.TryParse(pageName.Replace(" ", "_"), true, out PageType pageTypeParsed) == false)
                throw new ArgumentException($"String {pageName} can't be parsed to enum PageType!");

            switch (pageTypeParsed)
            {
                case PageType.SUPERBET:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.SuperbetLogo, 20).Click();
                        break;
                    }
                case PageType.SPORT:
                    {
                        Common.Wait(5);
                        _driver.WdFindElement(NavigationHeaderLOC.Sport, 20).Click();
                        break;
                    }
                case PageType.LIVE:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Live, 20).Click();
                        break;
                    }
                case PageType.GAMES:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Games, 20).Click();
                        break;
                    }
                case PageType.CASINO:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Casino, 20).Click();
                        break;
                    }
                case PageType.LOTTO:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Lotto, 20).Click();
                        break;
                    }
                case PageType.VIRTUAL:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Virtual, 20).Click();
                        break;
                    }
                case PageType.NEWS:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.News, 20).Click();
                        break;
                    }
                case PageType.RESULTS:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Results, 20).Click();
                        break;
                    }
                case PageType.SHOPS:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Shops, 20).Click();
                        break;
                    }
                case PageType.HELP:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Help, 20).Click();
                        break;
                    }
                case PageType.PLAYER_ACCOUNT:
                    {
                        _driver.WdMoveToElement(NavigationHeaderLOC.PlayerAccount);

                        _driver.WdFindElement(PlayerMenuLOC.NavigationAccountOverview, 20).Click();
                        break;
                    }
                case PageType.PLAYER_TICKETS:
                    {
                        _driver.WdMoveToElement(NavigationHeaderLOC.PlayerAccount);

                        _driver.WdFindElement(PlayerMenuLOC.NavigationTickets, 20).Click();
                        break;
                    }
                case PageType.PLAYER_HISTORY:
                    {
                        _driver.WdMoveToElement(NavigationHeaderLOC.PlayerAccount);

                        _driver.WdFindElement(PlayerMenuLOC.NavigationTransactionsHistory, 20).Click();
                        break;
                    }
            }
            _driver.JsWaitReadyStateComplete();
            _driver.WaitUntilElementIsInvisible(NavigationHeaderLOC.Spinner, 20);
        }

        public void NavigateToSportPage(string sportPageName)
        {
            if (Enum.TryParse(sportPageName, true, out SportBettingType sportBettingType) == false)
                throw new ArgumentException($"String {sportPageName} can't be parsed to enum SportBettingType!");

            switch (sportBettingType)
            {

                case SportBettingType.PREMATCH:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Sport, 20).Click();
                        break;
                    }
                case SportBettingType.INPLAY:
                    {
                        _driver.WdFindElement(NavigationHeaderLOC.Live, 20).Click();
                        break;
                    }
                case SportBettingType.SPECIAL:
                    {
                        _driver.WdFindElement(SportOfferLOC.NavigationSpecial, 20);
                        break;
                    }
            }

            _driver.WaitUntilElementIsInvisible(NavigationHeaderLOC.Spinner);

        }

        public void NavigateToSportGame(string sportGameType)
        {
            if (Enum.TryParse(sportGameType, true, out SportGameType sportGameTypeParsed) == false)
                throw new ArgumentException($"String {sportGameType} can't be parsed to enum SportGameType!");

            switch (sportGameTypeParsed)
            {

                case SportGameType.FOOTBALL:
                    {
                        _driver.WdFindElement(SportOfferLOC.NavigationFootball).Click();
                        break;
                    }
            }

        }
        #endregion

        #region Assertions

        public void IsThePageDisplayed(string pageName)
        {
            if (!Enum.TryParse(pageName.Replace(" ", "_"), true, out PageType pageTypeParsed))
                throw new ArgumentException($"String {pageName} page can't be parsed to enum PageType!");

            switch (pageTypeParsed)
            {
                case PageType.HOMEPAGE:
                    {
                        Assert.True(_driver.WdFindElement(SportOfferLOC.Prematch).Displayed, $"Homepage could not be opened. The element is not visible! Web element locator: {SportOfferLOC.Prematch}.");
                        break;
                    }
                case PageType.SPORT:
                    {
                        Assert.True(_driver.WdFindElement(SportOfferLOC.Prematch).Displayed, $"Sport page could not be opened. The element is not visible! Web element locator: {SportOfferLOC.Prematch}.");
                        break;
                    }
                case PageType.LIVE:
                    {
                        Assert.True(_driver.WdFindElement(SportOfferLOC.Inplay).Displayed, $"Live page could not be opened. The element is not visible! Web element locator: {SportOfferLOC.Inplay}.");
                        break;
                    }
                case PageType.GAMES:
                    {
                        Assert.True(_driver.WdFindElement(GamesLOC.Container).Displayed, $"Games page could not be opened. The element is not visible! Web element locator: {GamesLOC.Container}.");
                        break;
                    }
                case PageType.CASINO:
                    {
                        Assert.True(_driver.WdFindElement(CasinoLOC.WrapperGames).Displayed, $"Casino page could not be opened. The element is not visible! Web element locator: {CasinoLOC.WrapperGames}.");
                        break;
                    }
                case PageType.LOTTO:
                    {
                        Assert.True(_driver.WdFindElement(LottoLOC.GridEvents).Displayed, $"Lotto page could not be opened. The element is not visible! Web element locator: {LottoLOC.GridEvents}.");
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
        #endregion
    }
}