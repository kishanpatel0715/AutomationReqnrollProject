using OpenQA.Selenium;

namespace AutomationReqnrollProject.Helper
{
    class CommonMethods
    {
        WebDriver driver;

        public CommonMethods()
        {
            driver = Browser.driver;
        }

        public void Visit(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Click(By element)
        {
            driver.FindElement(element).Click();
        }
    }
}