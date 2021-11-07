using NUnit.Framework;
using SauceDemo.StepHelpers.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SauceDemo.StepDefinitions
{
    [Binding]
    public class ProductsSteps
    {
        private ProductsPage productsPage;
        private List<double> expectedProductsPrices;


        [When(@"I order the products by '(.*)'")]
        public void WhenIOrderTheProductsBy(string filterName)
        {
            productsPage = new ProductsPage();
            expectedProductsPrices = productsPage.GetProductsPrices();
            expectedProductsPrices.Sort();
            productsPage.SelectFilter(filterName);
        }

        [Then(@"The products are ordered by price from low to high")]
        public void ThenTheProductsAreOrderedByPriceFromLowToHigh()
        {
            List<double> expectedProductsPrices = productsPage.GetProductsPrices();
            Assert.That(expectedProductsPrices, Is.EquivalentTo(expectedProductsPrices));
        }

    }
}
