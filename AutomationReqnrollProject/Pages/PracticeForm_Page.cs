﻿using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Models;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.Pages
{
    class PracticeForm_Page
    {
        WebDriver driver;
        FormHelper formHelper;

        public PracticeForm_Page()
        {
            driver = Browser.GetDriver();
            formHelper = new FormHelper();
        }

        public By FirstNameElement = By.Id("firstName");
        public By LastNameElement = By.Id("lastName");
        public By EmailElement = By.Id("userEmail");
        public By MobileElement = By.Id("userNumber");
        public By SubjectsElement = By.Id("subjectsInput");
        public By PictureElement = By.Id("uploadPicture");
        public By CurrentAddressElement = By.Id("currentAddress");
        public By StateElement = By.Id("state");
        public By CityElement = By.Id("city");
        public By SubmitElement = By.Id("submit");
        public By FormsMenuElement = By.XPath("//*[text()='Forms']");
        public By PracticeFormSubmenuElement = By.XPath("/html/body/div[2]/div/div/div/div[1]/div/div/div[2]/div/ul/li/span");

        public void SelectFormsFromMenu()
        {
            driver.FindElement(FormsMenuElement).Click();
        }

        public void SelectPracticeFormFromSubMenu()
        {
            driver.FindElement(PracticeFormSubmenuElement).Click();
        }

        string FirstName
        {
            set => formHelper.EnterFormFieldData(FirstNameElement, value);
        }

        string LastName
        {
            set => formHelper.EnterFormFieldData(LastNameElement, value);
        }

        string Email
        {
            set => formHelper.EnterFormFieldData(EmailElement, value);
        }

        string Gender
        {
            set => formHelper.SelectCheckboxOrRadioButton(By.XPath($"//label[text()='{value}']"));
        }

        string Mobile
        {
            set => formHelper.EnterFormFieldData(MobileElement, value);
        }

        string Subjects
        {
            set
            {
                ScrollHelper.ScrollToTheElement(SubjectsElement);
                formHelper.EnterFormFieldData(SubjectsElement, value);
            }
        }

        string Hobbies
        {
            set => formHelper.SelectCheckboxOrRadioButton(By.XPath($"//label[text()='{value}']"));
        }

        string Picture
        {
            set => formHelper.EnterFormFieldData(PictureElement, value);
        }

        string CurrentAddress
        {
            set => formHelper.EnterFormFieldData(CurrentAddressElement, value);
        }

        string State
        {
            set => formHelper.SelectFromCustomDropDown(StateElement, value);
        }

        string City
        {
            set => formHelper.SelectFromCustomDropDown(CityElement, value);
        }

        public void EnterPracticeFormData(PracticeFormUIModel model)
        {
            FirstName = model.FirstName;
            LastName = model.LastName;
            Email = model.Email;
            Gender = model.Gender;
            Mobile = model.Mobile;
            Subjects = model.Subjects;
            Hobbies = model.Hobbies;
            Picture = model.Picture;
            CurrentAddress = model.CurrentAddress;
            State = model.State;
            City = model.City;
        }

        public void SubmitForm()
        {
            driver.FindElement(SubmitElement).Click();
        }

        public List<PracticeFormUIModel> GetSubmittedData()
        {
            List<PracticeFormUIModel> listOfFormData = new List<PracticeFormUIModel>();

            IWebElement table = driver.FindElement(By.ClassName("modal-body"));
            var columns = table.FindElements(By.TagName("td"));

            PracticeFormUIModel record = new PracticeFormUIModel()
            {
                FirstName = columns[1].Text,
                Email = columns[3].Text,
                Gender = columns[5].Text,
                Mobile = columns[7].Text,
                Hobbies = columns[13].Text,
                Picture = columns[15].Text,
                CurrentAddress = columns[17].Text,
                State = columns[19].Text,
            };

            listOfFormData.Add(record);
            return listOfFormData;
        }
    }
}