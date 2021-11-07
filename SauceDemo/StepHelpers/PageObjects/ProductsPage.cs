using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemo.StepHelpers.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SauceDemo.StepHelpers.PageObjects
{
    public class ProductsPage : BasePage
    {
        private readonly By _btnAddBackpack = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By _btnShoppingCart = By.Id("shopping_cart_container");
        private readonly By _titleProducts = By.CssSelector(".title");
        private readonly By _productsPrice = By.CssSelector(".inventory_item_price");
        private readonly By _productSort = By.CssSelector(".product_sort_container");

        public void AddBackpack()
        {
            IWebElement _addToCart = wait.Until(d => d.FindElement(this._btnAddBackpack));
            _addToCart.Click();
        }

        public void ClickShoppingCart()
        {
            IWebElement _shoppingCart = wait.Until(d => d.FindElement(this._btnShoppingCart));
            _shoppingCart.Click();
        }

        public bool IsTitlePresent()
        {
            try
            {
                IWebElement title = driver.FindElement(_titleProducts);
                return title.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public List<double> GetProductsPrices()
        {
            List<double> prices = new List<double>();
            ReadOnlyCollection<IWebElement> products = wait.Until(d => d.FindElements(_productsPrice));
            foreach (IWebElement product in products)
            {
                prices.Add(Double.Parse(product.Text.Remove(0, 1)));
            }
            return prices;
        }

        public void SelectFilter(String filterName)
        {
            IWebElement _selectElement = wait.Until(d => d.FindElement(this._productSort));
            var selectObject = new SelectElement(_selectElement);
            selectObject.SelectByText(filterName);
        }

    }
}
