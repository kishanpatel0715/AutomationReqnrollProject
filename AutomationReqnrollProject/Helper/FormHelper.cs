using OpenQA.Selenium;

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

        public void SelectFromDropDown(By selectElement, string selectOption)
        {
            driver.FindElement(selectElement).Click();
            driver.FindElement(By.XPath($"//div[text()='{selectOption}']")).Click();
        }
    }
}