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
        CommonMethods commonMethods;
        Alerts_Page alerts_Page;

        public Alert_StepDefinitions()
        {
            driver = Browser.driver;
            waitHelper = new WaitHelper();
            commonMethods = new CommonMethods();
            alerts_Page = new Alerts_Page();
        }

        [When("user navigates to the Alerts, Frame & Windows page page")]
        public void WhenUserNavigatesToTheAlertsFrameWindowsPagePage()
        {
            commonMethods.Visit("https://demoqa.com/alerts");
        }

        [When("user clicks on button to see alert")]
        public void WhenUserClicksOnButtonToSeeAlert()
        {
            alerts_Page.openAlert();
        }

        [Then("alert is displayed with text {string}")]
        public void ThenAlertIsDisplayedWithText(string alertExpectedText)
        {
            IAlert alert = driver.SwitchTo().Alert();
            Assert.AreEqual(alertExpectedText, alert.Text, "Alert Text is incorrect");
        }

        [When("user accepts the alert")]
        public void WhenUserAcceptsTheAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [Then("alert is disappeared")]
        public void ThenAlertIsDisappeared()
        {
            Assert.True(driver.FindElement(alerts_Page.AlertElement).Displayed, "Alert is still present");
        }

        [When("user clicks on button to see delayed alert")]
        public void WhenUserClicksOnButtonToSeeDelayedAlert()
        {
            alerts_Page.openDelayedAlert();
        }

        [Then("delayed alert is displayed with text {string}")]
        public void ThenDelayedAlertIsDisplayedWithText(string alertExpectedText)
        {
            waitHelper.WaitForAlert(5);
        }

        [When("user clicks on button to see confirm box")]
        public void WhenUserClicksOnButtonToSeeConfirmBox()
        {
            alerts_Page.openConfirmBoxPopUp();
        }

        [When("user cancels the alert")]
        public void WhenUserCancelsTheAlert()
        {
            //driver.SwitchTo().Alert().Dismiss();
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

            Assert.AreEqual(expectedMessage, actualMessage, "Incorrect message is displayed");
        }

        [When("user clicks on button to see prompt box")]
        public void WhenUserClicksOnButtonToSeePromptBox()
        {
            alerts_Page.openPromptBoxPopUp();
        }

        [When("user enters the name {string}")]
        public void WhenUserEntersTheName(string name)
        {
            AlertContext.name = name;
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys(name);
        }
    }
}