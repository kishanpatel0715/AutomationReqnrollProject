using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationReqnrollProject.Helper
{
    class FormHelper
    {
        WebDriver driver;

        public FormHelper()
        {
            driver = Browser.driver;
        } 

        public void EnterFormFieldData(By element, string value)
        {
            driver.FindElement(element).SendKeys(value);
        }

        public void SelectCheckboxOrRadioButton(By element)
        {
            driver.FindElement(element).Click();
        }

        public void SelectFromCustomDropDown(By selectElement, string selectOption)
        {
            driver.FindElement(selectElement).Click();
            driver.FindElement(By.XPath($"//div[text()='{selectOption}']")).Click();
        }

        public void SelectFromStandardDropDown(By selectElement, string selectOption)
        {
            SelectElement select = new SelectElement(driver.FindElement(selectElement));
            select.SelectByText(selectOption);
        }
    }
}