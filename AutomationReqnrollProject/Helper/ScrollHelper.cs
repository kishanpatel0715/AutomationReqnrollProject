using OpenQA.Selenium;

namespace AutomationReqnrollProject.Helper
{
    class ScrollHelper
    {
        static WebDriver driver = Browser.driver;
        public static void ScrollToTheElement(By element)
        {
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(element));
        }
    }
}