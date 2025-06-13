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
        public By BrowserWindowsSubmenuElement = By.XPath("/html/body/div[2]/div/div/div/div[1]/div/div/div[3]/div/ul/li[1]/span");

        public void SelectBrowserWindowsFromSubMenu()
        {
            driver.FindElement(BrowserWindowsSubmenuElement).Click();
        }
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