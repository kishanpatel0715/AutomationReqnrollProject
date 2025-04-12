using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    class WindowsTab_StepDefinitions
    {
        WebDriver driver;
        WindowsTab_Page windowsTab_Page;
        CommonMethods commonMethods;

        public WindowsTab_StepDefinitions()
        {
            driver = Browser.driver;
            windowsTab_Page = new WindowsTab_Page();
            commonMethods = new CommonMethods();
        }

        [Given("User is on the Browser Windows page")]
        public void GivenUserIsOnTheBrowserWindowsPage()
        {
            commonMethods.Visit("https://demoqa.com/browser-windows");
        }

        [When("user clicks on New Tab button")]
        public void WhenUserClicksOnNewTabButton()
        {
            windowsTab_Page.OpenNewTab();
        }

        [When("user navigates to the newly opened tab")]
        public void WhenUserNavigatesToTheNewlyOpenedTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        [Then("newly opened tab is displayed with text {string}")]
        public void ThenNewlyOpenedTabIsDisplayedWithText(string expectedText)
        {
            Assert.AreEqual(expectedText, windowsTab_Page.NewTabText, "Text is incorrect");
        }

        [When("user clicks on New Window button")]
        public void WhenUserClicksOnNewWindowButton()
        {
            windowsTab_Page.OpenNewWindow();
        }

        [When("user navigates to the newly opened window")]
        public void WhenUserNavigatesToTheNewlyOpenedWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        [Then("newly opened window is displayed with text {string}")]
        public void ThenNewlyOpenedWindowIsDisplayedWithText(string expectedText)
        {
            Console.WriteLine("Got Actual Text: " + windowsTab_Page.NewWindowText);
            Assert.AreEqual(expectedText, windowsTab_Page.NewWindowText, "Text is incorrect");
        }
    }
}