using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.Pages
{
    class Login_Page
    {
        WebDriver driver;
        public Login_Page()
        {
         this.driver = Browser.GetDriver();
        }

        public By UserNameElement = By.Id("user-name");
        public By PasswordElement = By.Id("password");
        public By LoginElement = By.Id("login-button");
        public By LogoutElement = By.Id("logout_sidebar_link");
        public By LoginErrorMessageElement = By.ClassName("error-message-container");
        public By SideMenuElement = By.Id("react-burger-menu-btn");

        public void EnterCredential(String userName, String password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            driver.FindElement(UserNameElement).SendKeys(userName);
            driver.FindElement(PasswordElement).SendKeys(password);          
        }

        public void Login()
        {
            driver.FindElement(LoginElement).Click();
        }

        public void OpensMenu()

        {
            driver.FindElement(SideMenuElement).Click();
        }

        public void Logout()
        {
            new WaitHelper().WaitForElementToBeVisible(LogoutElement, 5);
            driver.FindElement(LogoutElement).Click();
        }
    }
}