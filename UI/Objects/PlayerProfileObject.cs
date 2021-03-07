using NUnit.Framework;
using OpenQA.Selenium;
using UI.Models;

namespace UI.Objects
{
    class PlayerProfileObject
    {
        private readonly IWebDriver _driver;

        public PlayerProfileObject(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        #region Actions

        #endregion


        #region Assertions
        public void PlayerBalanceIsReducedByTheStake(double stake)
        {
            Assert.AreEqual(expected: PlayerProfileModel.BalanceAfterLogin - stake, actual: PlayerProfileModel.BalanceAfterPurchase, $"Player balance after purchase is not reduced by the ticket stake.");

        }
        #endregion
    }
}
