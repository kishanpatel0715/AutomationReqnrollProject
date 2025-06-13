using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    class WindowsTab_StepDefinitions
    {
        WebDriver driver;
        WindowsTab_Page windowsTab_Page;

        public WindowsTab_StepDefinitions()
        {
            driver = Browser.driver;
            windowsTab_Page = new WindowsTab_Page();
        }

        [Given("the user selects Browser Windows from sub-menu")]
        public void GivenTheUserSelectsBrowserWindowsFromSub_Menu()
        {
            windowsTab_Page.SelectBrowserWindowsFromSubMenu();
        }

        [When("the user clicks the New Tab button")]
        public void WhenTheUserClicksTheNewTabButton()
        {
            windowsTab_Page.OpenNewTab();
        }

        [When("the user switches to the newly opened tab")]
        public void WhenTheUserSwitchesToTheNewlyOpenedTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            /* Extras: If you want to do back and fourth between opened windows or tabs 
            // ReadOnlyCollection<string> windoHandles = driver.WindowHandles;
            //string[] windoHandles = driver.WindowHandles.ToArray();
            List<string> windoHandles = driver.WindowHandles.ToList();

            for (int i=0; i< windoHandles.Count; i++)
            {
                driver.SwitchTo().Window(windoHandles[i]);
            } */
        }

        [Then("the new tab is displayed with the text {string}")]
        public void ThenTheNewTabIsDisplayedWithTheText(string expectedText)
        {
            Assert.AreEqual(expectedText, windowsTab_Page.NewTabText, "Text is incorrect");
        }

        [When("the user clicks the New Window button")]
        public void WhenTheUserClicksTheNewWindowButton()
        {
            windowsTab_Page.OpenNewWindow();
        }

        [When("the user switches to the newly opened window")]
        public void WhenTheUserSwitchesToTheNewlyOpenedWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        [Then("the new window is displayed with the text {string}")]
        public void ThenTheNewWindowIsDisplayedWithTheText(string expectedText)
        {
            Assert.AreEqual(expectedText, windowsTab_Page.NewWindowText, "Text is incorrect");
        }
    }
}