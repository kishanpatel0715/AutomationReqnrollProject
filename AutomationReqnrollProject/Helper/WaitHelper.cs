using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationReqnrollProject.Helper
{
    class WaitHelper
    {
        WebDriver driver;
        WebDriverWait wait;

        public WaitHelper()
        { 
            this.driver = Browser.GetDriver();
        }

        public IWebElement WaitForElementToBeVisible(By element, int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        public IWebElement WaitForElementToBeEnableOrClickable(By element, int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public IWebElement WaitForElementUntilExist(By element, int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(ExpectedConditions.ElementExists(element));
        }

        public void WaitForElementUntilItDisappeares(By element, int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(element));
        }

        public void WaitForElementUntilItGetsText(By element, int timeOutInSeconds, string text)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(ExpectedConditions.TextToBePresentInElement(driver.FindElement(element), text));
        }

        public IAlert WaitForAlert(int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(ExpectedConditions.AlertIsPresent());
        }
    }
}