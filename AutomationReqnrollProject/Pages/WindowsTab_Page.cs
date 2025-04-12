using OpenQA.Selenium;
using AutomationReqnrollProject.Helper;

namespace AutomationReqnrollProject.Pages
{
    class WindowsTab_Page
    {
        WebDriver driver;

        public WindowsTab_Page()
        {
            driver = Browser.driver;
        }

        public By NewTabElement = By.Id("tabButton");
        public By NewTabTextElement = By.Id("sampleHeading");
        public By NewWindowElement = By.Id("windowButton");
        public By NewWindowTextElement = By.Id("sampleHeading");

        public void OpenNewTab()
        {
            driver.FindElement(NewTabElement).Click();
        }

        public void OpenNewWindow()
        {
            driver.FindElement(NewWindowElement).Click();
        }

        public string NewTabText
        {
            get => driver.FindElement(NewTabTextElement).Text;
        }

        public string NewWindowText
        {
            get => driver.FindElement(NewWindowTextElement).Text;
        }
    }
}