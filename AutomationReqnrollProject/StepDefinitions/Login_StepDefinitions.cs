using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public sealed class Login_StepDefinitions
    {
        WebDriver driver;
        Login_Page loginPage;

        public Login_StepDefinitions()
        {            
            driver = Browser.GetDriver();
            loginPage = new Login_Page();
        }

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            driver.Navigate().GoToUrl(TestContext.Parameters["BaseUrlSauceDemo"]);
        }

        [When("user enters {string} and {string}")]
        public void WhenUserEntersAnd(string userName, string password)
        {
            loginPage.EnterCredential(userName, password);
        }

        [When("user login")]
        public void WhenUserLogin()
        {
            loginPage.Login();
        }

        [Then("user is logged-in successfully")]
        public void ThenUserIsLogged_InSuccessfully()
        {
            bool isSideMenuIsDisplayed;
            try
            {
                isSideMenuIsDisplayed = driver.FindElement(loginPage.SideMenuElement).Displayed;
            }

            catch(NoSuchElementException)
            {
                isSideMenuIsDisplayed = false;
            }

            Assert.That(isSideMenuIsDisplayed, Is.True, "Login is failed");
        }

        [When(@"user enters invalid (.*) and (.*)")]
        public void WhenUserEntersInvalidCredentials(string userName, string password)
        {
            loginPage.EnterCredential(userName, password);
        }

        [When("user opens side-menu")]
        public void WhenUserOpensSideMenu()
        {
            loginPage.OpensMenu();
        }

        [When("user logout")]
        public void WhenUserLogout()
        {
            loginPage.Logout();
        }

        [Then("error message is displayed")]
        public void ThenErrorMessageIsDisplayed()
        {
            bool isErrorMessageDisplayed;

            try
            {
                isErrorMessageDisplayed = driver.FindElement(loginPage.LoginErrorMessageElement).Displayed;
            }

            catch(NoSuchElementException)
             {
                 isErrorMessageDisplayed = false;
             }

            Assert.That(isErrorMessageDisplayed, Is.True, "Invalid user gets logged in successfully");
        }

        [Then("user is logged-out")]
        public void ThenUserIsLogged_Out()
        {
            bool isLoginButtonDisplayed;

            try
            {
                isLoginButtonDisplayed = driver.FindElement(loginPage.LoginElement).Displayed;
            }

            catch (NoSuchElementException)
            {
                isLoginButtonDisplayed = false;
            }

            Assert.That(isLoginButtonDisplayed, Is.True, "Logout is failed");
        }
    }
}