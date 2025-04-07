using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationReqnrollProject.Pages
{
    class Login_Page
    {
        WebDriver driver;
        public Login_Page()
        {
         this.driver = Browser.driver;   
        }

        By userNameElement = By.Id("user-name");
        By passwordElement = By.Id("password");
        By loginElement = By.Id("login-button");
        By logoutElement = By.Id("logout_sidebar_link");
        By menu = By.CssSelector("#react-burger-menu-btn");

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
            driver.FindElement((menu)).Click();
        }
    }
}
