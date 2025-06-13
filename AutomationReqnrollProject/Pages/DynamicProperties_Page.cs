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
        public By DynamicPropertiesSubmenuElement = By.XPath("/html/body/div[2]/div/div/div/div[1]/div/div/div[1]/div/ul/li[9]/span");

        public void SelectDynamicPropertiesFromSubMenu()
        {
            driver.FindElement(DynamicPropertiesSubmenuElement).Click();
        }
    }
}