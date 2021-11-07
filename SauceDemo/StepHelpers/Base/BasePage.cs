using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace SauceDemo.StepHelpers.Base
{
    public class BasePage
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;

        public IWebDriver CreateDriver(Browser browsers)
        {
            switch (browsers)
            {
                case Browser.CHROME:
                    driver = new ChromeDriver();
                    break;
                case Browser.FIREFOX:
                    driver = new FirefoxDriver();
                    break;
            }

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            return driver;
        }
    }
}
