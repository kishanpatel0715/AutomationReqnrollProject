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

        public PracticeForm_StepDefinitions()
        {
            driver = Browser.driver;
            practiceForm_Page = new PracticeForm_Page();
            waitHelper = new WaitHelper();
        }

        [Given("the user selects the Forms from menu")]
        public void GivenTheUserSelectsTheFormsFromMenu()
        {
            practiceForm_Page.SelectFormsFromMenu();
        }

        [When("the user selects Practice Form from the sub-menu")]
        public void WhenTheUserSelectsPracticeFormFromTheSub_Menu()
        {
            practiceForm_Page.SelectPracticeFormFromSubMenu();
        }


        [When("the user enters following details:")]
        public void WhenTheUserEntersFollowingDetails(DataTable dataTable)
        {
            var input = dataTable.CreateInstance<PracticeFormUIModel>();

            practiceForm_Page.EnterPracticeFormData(input);
        }

        [When("the user submits the form")]
        public void WhenTheUserSubmitsTheForm()
        {
            practiceForm_Page.SubmitForm();
        }

        [Then("the form is submitted successfully")]
        public void ThenTheFormIsSubmittedSuccessfully()
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

        [Then("the following details are displayed:")]
        public void ThenTheFollowingDetailsAreDisplayed(DataTable dataTable)
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