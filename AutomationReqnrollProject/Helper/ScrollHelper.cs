using OpenQA.Selenium;

namespace AutomationReqnrollProject.Helper
{
    class ScrollHelper
    {
        WebDriver driver;
        public ScrollHelper()
        {
            driver = Browser.driver;
        }
        public void scrollToTheElement(By element)
        {
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(element));
        }
    }
}