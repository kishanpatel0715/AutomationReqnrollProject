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
        PracticeForm_Page practiceForm_Page;
        WaitHelper waitHelper;

        public PracticeForm_StepDefinitions()
        {
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
                IsSuccessMessageIsDisplayed = waitHelper.WaitForElementToBeVisible(By.Id("example-modal-sizes-title-lg"),3).Displayed; 
            }

            catch (NoSuchElementException)
            {
                IsSuccessMessageIsDisplayed = false;
            }

            Assert.That(IsSuccessMessageIsDisplayed, Is.True, "Form submission is failed");
        }

        [Then("the following details are displayed:")]
        public void ThenTheFollowingDetailsAreDisplayed(DataTable dataTable)
        {
            var input = dataTable.CreateInstance<PracticeFormUIModel>();

            var output = practiceForm_Page.GetSubmittedData();

            Assert.That(output[0].FirstName, Is.EqualTo(input.FirstName + " " + input.LastName), "First Name or Last Name is incorrect");
            Assert.That(output[0].Email, Is.EqualTo(input.Email), "Email is incorrect");
            Assert.That(output[0].Gender, Is.EqualTo(input.Gender), "Gender is incorrect");
            Assert.That(output[0].Mobile, Is.EqualTo(input.Mobile), "Mobile is incorrect");
            Assert.That(output[0].Hobbies, Is.EqualTo(input.Hobbies), "Hobbies is incorrect");
            Assert.That(output[0].Picture, Is.EqualTo(input.Picture), "Picture is incorrect");
            Assert.That(output[0].CurrentAddress, Is.EqualTo(input.CurrentAddress), "Current Address is incorrect");
            Assert.That(output[0].State, Is.EqualTo(input.State + " " + input.City), "State or City is incorrect");
        }
    }
}