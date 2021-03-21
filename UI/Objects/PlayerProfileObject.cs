using NUnit.Framework;
using UI.Models;

namespace UI.Objects
{
    class PlayerProfileObject
    {
        private readonly PlayerDetailsModel _playerBalance;
        private readonly BetslipModel _betslipStake;

        public PlayerProfileObject(PlayerDetailsModel playerDetails, BetslipModel betslipModel)
        {
            _playerBalance = playerDetails;
            _betslipStake = betslipModel;
        }

        #region Actions

        #endregion


        #region Assertions
        public void PlayerBalanceIsReducedByTheStake()
        {
            Assert.AreEqual(expected: _playerBalance.BalanceAfterLogin - _betslipStake.Stake, actual: _playerBalance.BalanceAfterPurchase, $"Player balance after purchase is not reduced by the ticket stake.");

        }
        #endregion
    }
}
