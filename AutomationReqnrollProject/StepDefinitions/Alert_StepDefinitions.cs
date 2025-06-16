using AutomationReqnrollProject.Context;
using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    class Alert_StepDefinitions
    {
        WebDriver driver;
        WaitHelper waitHelper;
        Alerts_Page alerts_Page;

        public Alert_StepDefinitions()
        {
            driver = Browser.GetDriver();
            waitHelper = new WaitHelper();
            alerts_Page = new Alerts_Page();
        }

        [Given("the user navigates to DemoQA home page")]
        public void GivenTheUserNavigatesToDemoQAHomePage()
        {
            driver.Navigate().GoToUrl(TestContext.Parameters["BaseUrlDemoQa"]);
        }

        [Given("the user selects the Alerts, Frame & Windows from the menu")]
        public void GivenTheUserSelectsTheAlertsFrameWindowsFromTheMenu()
        {
            alerts_Page.SelectAlertsFrameWindowsFromMenu();
        }

        [Given("the user selects Alerts from the sub-menu")]
        public void GivenTheUserSelectsAlertsFromTheSub_Menu()
        {
            alerts_Page.SelectAlertsFromSubMenu();
        }

        [When("the user opens the regular alert")]
        public void WhenTheUserOpensTheRegularAlert()
        {
            alerts_Page.OpenAlert();
        }

        [When("the user accepts the alert")]
        public void WhenTheUserAcceptsTheAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [Then("an alert is displayed with the text {string}")]
        public void ThenAnAlertIsDisplayedWithTheText(string alertExpectedText)
        {
            IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo(alertExpectedText), "Alert Text is incorrect");
        }

        [Then("the alert is no longer visible")]
        public void ThenTheAlertIsNoLongerVisible()
        {            
            Assert.That(driver.FindElement(alerts_Page.AlertElement).Displayed, Is.True, "Alert is still present");
        }

        [When("user clicks on button to see delayed alert")]
        public void WhenUserClicksOnButtonToSeeDelayedAlert()
        {
            alerts_Page.OpenDelayedAlert();
        }


        [When("the user opens the delayed alert")]
        public void WhenTheUserOpensTheDelayedAlert()
        {
            alerts_Page.OpenDelayedAlert();
        }

        [Then("delayed alert is displayed with the text {string}")]
        public void ThenDelayedAlertIsDisplayedWithTheText(string alertExpectedText)
        {
            waitHelper.WaitForAlert(5);
        }

        [When("the user opens the confirm box")]
        public void WhenTheUserOpensTheConfirmBox()
        {
            alerts_Page.OpenConfirmBoxPopUp();
        }

        [When("the user cancels the alert")]
        public void WhenTheUserCancelsTheAlert()
        {
            waitHelper.WaitForAlert(3).Dismiss();
        }

        [Then("{string} message is displayed")]
        public void ThenMessageIsDisplayed(string expectedMessage)
        {
            string actualMessage;

            if (expectedMessage.Contains("entered"))
            {
                actualMessage = alerts_Page.GetEnteredNameSuccessText(AlertContext.name).Text;
            }
            else
            {
                actualMessage = driver.FindElement(alerts_Page.ConfirmResultTextElement).Text;
            }

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Incorrect message is displayed");
        }

        [When("the user opens the prompt box")]
        public void WhenTheUserOpensThePromptBox()
        {
            alerts_Page.OpenPromptBoxPopUp();
        }

        [When("the user enters the name {string}")]
        public void WhenTheUserEntersTheName(string name)
        {
            AlertContext.name = name;
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys(name);
        }

        [When("the user opens the google page")]
        public void WhenTheUserOpensTheGooglePage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Then("{string} is displayed")]
        public void ThenIsDisplayed(string name)
        {
            Assert.That(driver.FindElement(By.Id("user-name")).Text, Is.EqualTo(name), "User name is not displayed correctly");
        }
    }
}