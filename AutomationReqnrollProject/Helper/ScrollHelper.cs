using OpenQA.Selenium;

namespace AutomationReqnrollProject.Helper
{
    class ScrollHelper
    {
        static WebDriver driver = Browser.GetDriver();
        public static void ScrollToTheElement(By element)
        {
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(element));
        }
    }
}