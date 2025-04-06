using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef
        WebDriver driver;
        LoginPage loginPage;
        WaitHelper waitHelper;
       
       
        public LoginStepDefinitions()
        {            
            driver = Browser.driver;
            loginPage = new LoginPage();
            waitHelper = new WaitHelper(driver);
        }

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            driver.Navigate().GoToUrl(TestContext.Parameters["BaseUrl"]);
        }

        [When("User enters {string} and {string}")]
        public void WhenUserEntersAnd(string userName, string password)
        {
            loginPage.EnterCredential(userName, password);
        }

        [When("Clicks on login button")]
        public void WhenClicksOnLoginButton()
        {
            loginPage.login();
        }

        [Then("User should be redirected to the home page")]
        public void ThenUserShouldBeRedirectedToTheHomePage()
        {
            Assert.That(driver.Title, Is.EqualTo("Swag Labs"), "User is not logged in successfully");
           // loginPage.opensMenu();
            //  Assert.True(driver.FindElement(By.Id("react-burger-menu-btn")).Displayed, "User is not logged in successfully");
        }

        [When(@"User enters invalid (.*) and (.*)")]
        public void WhenUserEntersInvalidCredentials(string userName, string password)
        {
            loginPage.EnterCredential(userName, password);
        }

        [When("user opens menu")]
        public void WhenUserOpensMenu()
        {
            loginPage.opensMenu();
        }

        [Then("Logout option is displayed")]
        public void ThenLogoutOptionIsDisplayed()
        {
            //Thread.Sleep(9000);
            waitHelper.WaitForElementToBeVisible(By.Id("logout_sidebar_link"), 9);
            Assert.IsTrue(driver.FindElement(By.Id("logout_sidebar_link")).Displayed, "Logout option is not displayed");
        }

    }
}