using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.Pages
{
    class Alerts_Page
    {
        WebDriver driver;

        public Alerts_Page()
        {
            driver = Browser.driver;
        }

        public By AlertElement = By.Id("alertButton");
        public By DelayedAlertElement = By.XPath("//*[contains(@id, 'timerAlert')]");
        public By ConfirmBoxElement = By.XPath("//*[starts-with(@id, 'confirmButton')]");
        public By ConfirmResultTextElement = By.XPath("//*[text()='Cancel' or text()='Ok']");
        public By PromptElement = By.Id("promtButton");
        public By AlertsFrameWindowsMenuElement = By.XPath("//*[text()='Alerts, Frame & Windows']");
        public By AlertsSubmenuElement = By.XPath("/html/body/div[2]/div/div/div/div[1]/div/div/div[3]/div/ul/li[2]/span");

        public void SelectAlertsFrameWindowsFromMenu()
        {
            driver.FindElement(AlertsFrameWindowsMenuElement).Click();
        }

        public void SelectAlertsFromSubMenu()
        {
            driver.FindElement(AlertsSubmenuElement).Click();
        }
        public IWebElement GetEnteredNameSuccessText(string name)
        {
            return driver.FindElement(By.XPath($"//*[text()= '{name}']"));
        }

        public void OpenAlert()
        {
           driver.FindElement(AlertElement).Click();
        }

        public void OpenDelayedAlert()
        {
            driver.FindElement(DelayedAlertElement).Click();
        }

        public void OpenConfirmBoxPopUp()
        {
            driver.FindElement(ConfirmBoxElement).Click();
        }

        public void OpenPromptBoxPopUp()
        {
            driver.FindElement(PromptElement).Click();
        }
    }
}