using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
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

        public static WebDriver getDriver(String browser)
        {

            switch (browser.ToLower())
            {
                case "chrome":
                    return getChromeDriver();

                case "edge":
                    return getEdgeDriver();

                default:
                    return getFireFoxDriver();
            }
        }

        public static WebDriver getChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-popup-blocking");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--no-sandbox");

            if (TestContext.Parameters["Headless"] == "true")
            {
                chromeOptions.AddArgument("--headless");
            }

            driver = new ChromeDriver(chromeOptions);

            return driver;
        }

        public static WebDriver getEdgeDriver()
        {
            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--start-maximized");
            edgeOptions.AddArgument("--disable-notifications");
            edgeOptions.AddArgument("--disable-extensions");
            edgeOptions.AddArgument("--disable-popup-blocking");
            edgeOptions.AddArgument("--disable-gpu");
            edgeOptions.AddArgument("--incognito");
            edgeOptions.AddArgument("--no-sandbox");

            if (TestContext.Parameters["Headless"] == "true")
            {
                edgeOptions.AddArgument("--headless");

            }

            driver = new EdgeDriver(edgeOptions);

            return driver;
        }

        public static WebDriver getFireFoxDriver()
        {
            FirefoxOptions fireFoxOptions = new FirefoxOptions();
            fireFoxOptions.AddArgument("--start-maximized");
            fireFoxOptions.AddArgument("--disable-notifications");
            fireFoxOptions.AddArgument("--disable-extensions");
            fireFoxOptions.AddArgument("--disable-popup-blocking");
            fireFoxOptions.AddArgument("--disable-gpu");
            fireFoxOptions.AddArgument("--incognito");
            fireFoxOptions.AddArgument("--no-sandbox");

            if (TestContext.Parameters["Headless"] == "true")
            {
                fireFoxOptions.AddArgument("--headless");

            }

            driver = new FirefoxDriver(fireFoxOptions);

            return driver;
        }
    }
}