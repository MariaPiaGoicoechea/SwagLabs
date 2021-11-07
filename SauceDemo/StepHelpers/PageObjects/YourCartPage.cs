using OpenQA.Selenium;
using SauceDemo.StepHelpers.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SauceDemo.StepHelpers.PageObjects
{
    public class YourCartPage : BasePage
    {
        private readonly By _btnCheckout = By.Id("checkout");
        private readonly By _cartItems = By.CssSelector(".inventory_item_name");

        public void ClickCheckout()
        {
            IWebElement _checkout = wait.Until(d => d.FindElement(this._btnCheckout));
            _checkout.Click();
        }

        public List<string> GetCartItemsNames()
        {
            List<string> names = new List<string>();
            ReadOnlyCollection<IWebElement> products = wait.Until(d => d.FindElements(_cartItems));
            foreach (IWebElement product in products)
            {
                names.Add(product.Text);
            }
            return names;
        }
    }
}
