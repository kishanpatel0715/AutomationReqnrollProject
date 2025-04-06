using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationReqnrollProject.Helper
{
    class Browser
    {
        public static WebDriver? driver;
    
        public static WebDriver getDriver()
        {
               driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
