using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationReqnrollProject.Helper
{
    class WaitHelper
    {
        WebDriver driver;

        public WaitHelper()
        { 
            this.driver = Browser.driver;
        }

        public void WaitForElementToBeVisible(By element, int timeOutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
    }
}