using OpenQA.Selenium;
using SauceDemo.StepHelpers.Base;

namespace SauceDemo.StepHelpers.PageObjects
{
    public class OverviewPage : BasePage
    {
        private readonly By _btnFinish = By.Id("finish");

        public void ClickFinish()
        {
            IWebElement _finish = wait.Until(d => d.FindElement(this._btnFinish));
            _finish.Click();
        }
    }
}
