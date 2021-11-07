using OpenQA.Selenium;
using SauceDemo.StepHelpers.Base;
using System;

namespace SauceDemo.StepHelpers.PageObjects
{
    public class YourInformationPage : BasePage
    {
        private readonly By _btnContinue = By.Id("continue");
        private readonly By _btnCancel = By.Id("cancel");
        private readonly By _txtFirstName = By.Id("first-name");
        private readonly By _txtLastName = By.Id("last-name");
        private readonly By _txtPostalCode = By.Id("postal-code");

        public void CompleteFirstName(String firstname)
        {
            IWebElement _firstName = wait.Until(d => d.FindElement(this._txtFirstName));
            _firstName.SendKeys(firstname);
        }

        public void CompleteLastName(String lastname)
        {
            IWebElement _lastName = wait.Until(d => d.FindElement(this._txtLastName));
            _lastName.SendKeys(lastname);
        }

        public void CompletePostalCode(String postalCode)
        {
            IWebElement _postalCode = wait.Until(d => d.FindElement(this._txtPostalCode));
            _postalCode.SendKeys(postalCode);
        }

        public void ClickContinue()
        {
            IWebElement _continue = wait.Until(d => d.FindElement(this._btnContinue));
            _continue.Click();
        }

        public void ClickCancel()
        {
            IWebElement _cancel = wait.Until(d => d.FindElement(this._btnCancel));
            _cancel.Click();
        }
    }
}
