using System;
using OpenQA.Selenium;
using SauceDemo.StepHelpers.Base;

namespace SauceDemo.StepHelpers.PageObjects
{
    public class LoginPage : BasePage
    {
        private readonly By _txtUsername = By.Id("user-name");
        private readonly By _txtPassword = By.Id("password");
        private readonly By _btnLogin = By.Id("login-button");
        private readonly By _msgError = By.XPath("//h3[contains(text(),'Sorry, this user has been locked out')]");

        public LoginPage(Browser browser)
        {
            CreateDriver(browser);
        }

        public void Close()
        {
            driver.Close();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void LaunchSite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        
        public void EnterCredentials(String username, String password)
        {
            IWebElement _username = wait.Until(d => d.FindElement(this._txtUsername));
            _username.SendKeys(username);
            IWebElement _password = wait.Until(d => d.FindElement(this._txtPassword));
            _password.SendKeys(password);
        }

        public void ClickLogin()
        {
            IWebElement _login = wait.Until(d => d.FindElement(this._btnLogin));
            _login.Click();
        }

        public bool IsMessageErrorPresent()
        {
            try
            {
                IWebElement message = driver.FindElement(_msgError);
                return message.Displayed;
            } catch (NoSuchElementException)
            {
                return false;
            }
            
        }

    }
}
