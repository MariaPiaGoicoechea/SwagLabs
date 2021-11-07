using NUnit.Framework;
using SauceDemo.StepHelpers.Base;
using SauceDemo.StepHelpers.PageObjects;
using TechTalk.SpecFlow;


namespace SauceDemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private static LoginPage loginPage;
        private ProductsPage productsPage;

        public static LoginPage GetLoginPage()
        {
            return loginPage;
        }

        [Given(@"I launch the SauceDemo webpage")]
        public void GivenILaunchTheSauceDemoWebpage()
        {
            loginPage = new LoginPage(Browser.CHROME);
            loginPage.LaunchSite();
        }

        [Given(@"I enter the username '(.*)' and the password '(.*)' of a user")]
        [When(@"I enter the username '(.*)' and the password '(.*)' of a user")]
        public void WhenIEnterTheUsernameAndThePasswordOfALockedUser(string username, string password)
        {
            loginPage.EnterCredentials(username, password);
            loginPage.ClickLogin();
        }

        [Then(@"appears an error message")]
        public void ThenAppearsAnErrorMessage()
        {
            Assert.IsTrue(loginPage.IsMessageErrorPresent());
        }

        [Then(@"User is successfully logged in and taken to the Products page")]
        public void ThenUserIsSuccessfullyLoggedInAndTakenToTheProductsPage()
        {    
            productsPage = new ProductsPage();
            productsPage.IsTitlePresent();
        }





    }
}
