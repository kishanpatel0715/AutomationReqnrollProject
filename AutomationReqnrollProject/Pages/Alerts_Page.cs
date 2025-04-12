using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.Pages
{
    class Alerts_Page
    {
        WebDriver driver;
        CommonMethods commonMethods;

        public Alerts_Page()
        {
            driver = Browser.driver;
            commonMethods = new CommonMethods();
        }

        public By AlertElement = By.Id("alertButton");
        public By DelayedAlertElement = By.XPath("//*[contains(@id, 'timerAlert')]");
        public By ConfirmBoxElement = By.XPath("//*[starts-with(@id, 'confirmButton')]");
        public By ConfirmResultTextElement = By.XPath("//*[text()='Cancel' or text()='Ok']");
        public By PromptElement = By.Id("promtButton");

        public IWebElement GetEnteredNameSuccessText(string name)
        {
            return driver.FindElement(By.XPath($"//*[text()= '{name}']"));
        }

        public void openAlert()
        {
            commonMethods.Click(AlertElement);
        }

        public void openDelayedAlert()
        {
            commonMethods.Click(DelayedAlertElement);
        }

        public void openConfirmBoxPopUp()
        {
            commonMethods.Click(ConfirmBoxElement);
        }

        public void openPromptBoxPopUp()
        {
            commonMethods.Click(PromptElement);
        }
    }
}