using OpenQA.Selenium;

namespace UI.Locators
{
    class BetslipLOC
    {
        public static By EventValidationMessage { get; } = By.CssSelector(".selection-row__error-message");
        public static By EventsCount { get; } = By.CssSelector(".betslip__controls-events-info-number");
        public static By PotentialWin { get; } = By.CssSelector(".betslip__potential-gain-amount");
        public static By OddTotal { get; } = By.CssSelector(".betslip-stake__total-quota-number");
        public static By ContainerBetslip { get; } = By.CssSelector(".betslip");
        public static By RowEvent { get; } = By.CssSelector(".selection-row");
        public static By CheckboxMarket { get; } = By.CssSelector(".selection-row__selection-switch");
        public static By InputFieldStake { get; } = By.CssSelector(".input__field");
        public static By ButtonDeleteEvent { get; } = By.CssSelector(".betslip-body__side .icon-delete");
        public static By ButtonCopy { get; } = By.CssSelector(".icon-duplicate");
        public static By ButtonMultiBetslipSwitch { get; } = By.CssSelector(".multi-betslip-controls__pill");
        public static By ButtonClear { get; } = By.CssSelector(".betslip__controls-action .icon-delete");
        public static By ButtonPurchase { get; } = By.CssSelector(".betslip__actions .betslip__button");
        public static By ButtonSimpleTicket { get; } = By.CssSelector(".betslip-header .e2e-binary-switcher-first");
        public static By ButtonSystemTicket { get; } = By.CssSelector(".betslip-header .e2e-binary-switcher-second");
        public static By ButtonOnlineTicket { get; } = By.CssSelector(".betslip-footer .e2e-binary-switcher-first");
        public static By ButtonOfflineTicket { get; } = By.CssSelector(".betslip-footer .e2e-binary-switcher-second");
        public static By ButtonTicketPreview { get; } = By.CssSelector(".betslip__ticket-preview");
        public static By ButtonStakePicker { get; } = By.CssSelector(".betslip-stake__picker");

    }
}
