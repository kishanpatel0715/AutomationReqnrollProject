using OpenQA.Selenium;
using AutomationReqnrollProject.Helper;

namespace AutomationReqnrollProject.Pages
{
    class DynamicProperties_Page
    {
        WebDriver driver;

        public DynamicProperties_Page()
        {
            driver = Browser.driver;
        }

        public By VisibleAfter5SecElement = By.Id("visibleAfter");
        public By EnabledAfter5SecElement = By.Id("enableAfter");
    }
}