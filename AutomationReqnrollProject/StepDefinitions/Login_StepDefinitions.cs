using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public sealed class Login_StepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef
        WebDriver driver;
        Login_Page loginPage;
        CommonMethods commonMethods;
        public Login_StepDefinitions()
        {            
            driver = Browser.driver;
            loginPage = new Login_Page();
            commonMethods = new CommonMethods();
        }

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            commonMethods.Visit(TestContext.Parameters["BaseUrl"]);
        }

        [When("user enters {string} and {string}")]
        public void WhenUserEntersAnd(string userName, string password)
        {
            loginPage.EnterCredential(userName, password);
        }

        [When("user login")]
        public void WhenUserLogin()
        {
            loginPage.login();
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

            Assert.True(isSideMenuIsDisplayed, "Login is failed");
        }

        [When(@"user enters invalid (.*) and (.*)")]
        public void WhenUserEntersInvalidCredentials(string userName, string password)
        {
            loginPage.EnterCredential(userName, password);
        }

        [When("user opens side-menu")]
        public void WhenUserOpensSideMenu()
        {
            loginPage.opensMenu();
        }

        [When("user logout")]
        public void WhenUserLogout()
        {
            loginPage.logout();
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

            Assert.True(isErrorMessageDisplayed, "Invalid user gets logged in successfully");
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

            Assert.True(isLoginButtonDisplayed, "Logout is failed");
        }
    }
}