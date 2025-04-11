using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Models;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq.Expressions;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public class PracticeForm_StepDefinitions
    {
        WebDriver driver;
        PracticeForm_Page practiceForm_Page;
        WaitHelper waitHelper;
        CommonMethods commonMethods;

        public PracticeForm_StepDefinitions()
        {
            driver = Browser.driver;
            practiceForm_Page = new PracticeForm_Page();
            waitHelper = new WaitHelper();
            commonMethods = new CommonMethods();
        }

        [When("user navigates to the practice form page")]
        public void WhenUserNavigatesToThePracticeFormPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        }

        [When("user enters following details:")]
        public void WhenUserEntersFollowingDetails(DataTable dataTable)
        {
            var input = dataTable.CreateInstance<PracticeFormUIModel>();

            practiceForm_Page.EnterPracticeFormData(input);
        }

        [When("user submits the form")]
        public void WhenUserSubmitsTheForm()
        {
            practiceForm_Page.submitForm();
        }

        [Then("form is submitted successfully")]
        public void ThenFormIsSubmittedSuccessfully()
        {
            bool IsSuccessMessageIsDisplayed;

            try
            {
                IsSuccessMessageIsDisplayed = driver.FindElement(By.Id("example-modal-sizes-title-lg")).Displayed;
            }

            catch (NoSuchElementException)
            {
                IsSuccessMessageIsDisplayed = false;
            }

            Assert.True(IsSuccessMessageIsDisplayed, "Form submission is failed");
        }

        [Then("following details are displayed")]
        public void ThenFollowingDetailsAreDisplayed(DataTable dataTable)
        {
            var input = dataTable.CreateInstance<PracticeFormUIModel>();

            var output = practiceForm_Page.GetSubmittedData();

            Assert.AreEqual(input.FirstName + " " + input.LastName, output[0].FirstName, "First Name or Last Name is incorrect");
            Assert.AreEqual(input.Email, output[0].Email, "Email is incorrect");
            Assert.AreEqual(input.Gender, output[0].Gender, "Gender is incorrect");
            Assert.AreEqual(input.Mobile, output[0].Mobile, "Mobile is incorrect");
            Assert.AreEqual(input.Hobbies, output[0].Hobbies, "Hobbies is incorrect");
            Assert.AreEqual(input.Picture, output[0].Picture, "Picture is incorrect");
            Assert.AreEqual(input.CurrentAddress, output[0].CurrentAddress, "Current Address is incorrect");
            Assert.AreEqual(input.State + " " + input.City, output[0].State, "State or City is incorrect");
        }

        [When("user navigates to the Dynamic Properties page")]
        public void WhenUserNavigatesToTheDynamicPropertiesPage()
        {
            commonMethods.Visit("https://demoqa.com/dynamic-properties");
        }

        [Then("after {int} seconds, button is visible")]
        public void ThenAfterSecondsButtonIsVisible(int p0)
        {
            bool isElementDisplayedAfter5Sec;

            try
            {
                isElementDisplayedAfter5Sec = waitHelper.WaitForElementToBeVisible(practiceForm_Page.VisibleAfter5SecElement, 1).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                isElementDisplayedAfter5Sec = false;
            }
            catch (NoSuchElementException)
            {
                isElementDisplayedAfter5Sec = false;
            }

            Assert.True(isElementDisplayedAfter5Sec, "Button is not visible after 5 seconds");
        }

        [Then("after {int} seconds, button is enabled")]
        public void ThenAfterSecondsButtonIsEnabled(int p0)
        {
            bool isElementEnabledAfter5Sec;
            try
            {
                isElementEnabledAfter5Sec = waitHelper.WaitForElementToBeEnableOrClickable(practiceForm_Page.EnabledAfter5SecElement, 5).Enabled;
            }

            catch(Exception e)
            {
                isElementEnabledAfter5Sec = false;
            }

            Assert.True(isElementEnabledAfter5Sec, "Button is not enabled after 5 seconds");
        }

        [When("user navigates to the Alerts, Frame & Windows page page")]
        public void WhenUserNavigatesToTheAlertsFrameWindowsPagePage()
        {
            commonMethods.Visit("https://demoqa.com/alerts");
        }

        [When("user clicks on button to see alert")]
        public void WhenUserClicksOnButtonToSeeAlert()
        {
            commonMethods.Click(practiceForm_Page.AlertElement);
        }

        [Then("alert is displayed with text {string}")]
        public void ThenAlertIsDisplayedWithText(string alertExpectedText)
        {
            //IAlert alert = driver.SwitchTo().Alert();

            IAlert alert = waitHelper.WaitForAlert(5);
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
            Assert.True(driver.FindElement(practiceForm_Page.AlertElement).Displayed, "Alert is still present");
        }
    }
}