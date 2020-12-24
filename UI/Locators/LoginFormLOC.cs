using OpenQA.Selenium;

namespace UI.Locators
{
    class LoginFormLOC
    {
        public static By ButtonSubmit { get; } = By.CssSelector("#login-modal-submit");
        public static By FieldUsername { get; } = By.CssSelector(".input__field-box .input__field");
        public static By FieldPassword { get; } = By.CssSelector(".password-input .input__field");

    }
}
