using NUnit.Framework;
using SauceDemo.StepHelpers.PageObjects;
using TechTalk.SpecFlow;

namespace SauceDemo.StepDefinitions
{
    [Binding]
    public class CheckoutSteps
    {
        private YourCartPage yourCartPage;
        private YourInformationPage yourInformationPage;
        private OverviewPage overviewPage;
        private YourPage yourPage;

        [Given(@"I start the checkout")]
        public void GivenIStartTheCheckout()
        {
            yourCartPage = new YourCartPage();
            yourCartPage.ClickCheckout();
        }

        [When(@"I complete my information")]
        public void WhenICompleteMyInformation()
        {
            yourInformationPage = new YourInformationPage();
            yourInformationPage.CompleteFirstName("test");
            yourInformationPage.CompleteLastName("test");
            yourInformationPage.CompletePostalCode("7000");   
        }

        [When(@"I click continue")]
        public void WhenIClickContinue()
        {
            yourInformationPage.ClickContinue();
        }

        [When(@"I finish the checkout")]
        public void WhenIFinishTheCheckout()
        {
            overviewPage = new OverviewPage();
            overviewPage.ClickFinish();
        }

        [Then(@"Checkout is successfully completed")]
        public void ThenCheckoutIsSuccessfullyCompleted()
        {
            yourPage = new YourPage();
            Assert.IsTrue(yourPage.IsCheckoutComplete());
        }
    }
}
