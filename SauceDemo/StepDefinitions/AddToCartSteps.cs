using NUnit.Framework;
using SauceDemo.StepHelpers.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SauceDemo.StepDefinitions
{
    [Binding]
    public class AddToCartSteps
    {
        private ProductsPage productsPage;
        private YourCartPage yourCartPage;

        [Given(@"I add the product '(.*)' to the cart")]
        [When(@"I add the product '(.*)' to the cart")]
        public void GivenIAddTheProductToTheCart(string productName)
        {
            productsPage = new ProductsPage();
            switch (productName)
            {
                case "Sauce Labs Backpack":
                    productsPage.AddBackpack();
                    break;
            }
        }

        [Given(@"I go to see my cart")]
        [When(@"I go to see my cart")]
        public void GivenIGoToSeeMyCart()
        {
            productsPage.ClickShoppingCart();
        }

        [Then(@"The product '(.*)' should be in the cart")]
        public void ThenTheProductShouldBeInTheCart(string product)
        {
            yourCartPage = new YourCartPage();
            List<string> cartItemsNames = yourCartPage.GetCartItemsNames();
            Assert.IsTrue(cartItemsNames.Count == 1);
            Assert.IsTrue(cartItemsNames.Contains(product));
        }

    }
}
