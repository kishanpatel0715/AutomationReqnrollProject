using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace AutomationReqnrollProject.Helper
{
    class WaitHelper
    {
        WebDriver driver;
        public WaitHelper(WebDriver driver)
        { 
            this.driver = driver;
        }

        public void WaitForElementToBeVisible(By element, int timeOutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
    }
}
