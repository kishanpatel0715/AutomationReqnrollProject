using AutomationReqnrollProject.Context;
using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Models;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

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
    }
}