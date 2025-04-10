using System;
using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;
using Reqnroll;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public class WebLogin_StepDefinitions
    {
        WebDriver driver;

        public WebLogin_StepDefinitions()
        {
            driver = Browser.driver;
        }

        [When("User enters weblogin credentials {string} and {string}")]
        public void WhenUserEntersWebloginCredentialsAnd(string email, string pswd)
        {
            driver.Navigate().GoToUrl("https://appara.ai/");
            driver.FindElement(By.LinkText("Log in")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(pswd);
        }

        [When("Clicks on Weblogin button")]
        public void WhenClicksOnWebloginButton()
        {
            driver.FindElement(By.Id("next")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("sendCode")).Click();
            Thread.Sleep(1000000);

        }

        [Then("User should be redirected to the weblogin home page")]
        public void ThenUserShouldBeRedirectedToTheWebloginHomePage()
        {
            throw new PendingStepException();
        }
    }
}
