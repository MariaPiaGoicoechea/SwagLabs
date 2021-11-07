using OpenQA.Selenium;
using SauceDemo.StepHelpers.Base;

namespace SauceDemo.StepHelpers.PageObjects
{
    public class YourPage : BasePage
    {
        private readonly By _txtComplete = By.CssSelector(".title");

        public bool IsCheckoutComplete()
        {
            return driver.FindElement(_txtComplete).Displayed;
        }

    }
}
