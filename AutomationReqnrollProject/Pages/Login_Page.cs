using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.Pages
{
    class Login_Page
    {
        WebDriver driver;
        public Login_Page()
        {
         this.driver = Browser.driver;   
        }

        public By userNameElement = By.Id("user-name");
        public By passwordElement = By.Id("password");
        public By loginElement = By.Id("login-button");
        public By logoutElement = By.Id("logout_sidebar_link");
        public By loginErrorMessageElement = By.ClassName("error-message-container");
        public By sideMenuElement = By.Id("react-burger-menu-btn");

        public void EnterCredential(String userName, String password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            driver.FindElement(userNameElement).SendKeys(userName);
            driver.FindElement(passwordElement).SendKeys(password);          
        }

        public void login()
        {
            driver.FindElement(loginElement).Click();
        }

        public void opensMenu()

        {
            driver.FindElement((sideMenuElement)).Click();
        }

        public void logout()
        {
            new WaitHelper(driver).WaitForElementToBeVisible(logoutElement, 5);
            driver.FindElement(logoutElement).Click();
        }
    }
}