using OpenQA.Selenium;

namespace UI.Locators
{
    class GamesLOC
    {
        public static By Container { get; } = By.CssSelector(".games__content-container");
        public static By FieldSearch { get; } = By.CssSelector(".expandable-search__input");
        public static By FieldSearchInput { get; } = By.CssSelector(".expandable-search__input input");
        public static By Items { get; } = By.CssSelector(".games__item");
        public static By Title { get; } = By.CssSelector(".games__item-title");
        public static By ButtonPlay { get; } = By.CssSelector(".btn__primary");
    }
}
