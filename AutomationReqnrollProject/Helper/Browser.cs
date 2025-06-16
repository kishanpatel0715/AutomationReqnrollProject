using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace AutomationReqnrollProject.Helper
{
    class Browser
    {
        public static string downloadPath = Path.GetFullPath(TestContext.Parameters["DownloadPath"]);
        private static ThreadLocal<WebDriver> threadLocal = new ThreadLocal<WebDriver>();

        public static void SetDriver(String browser)
        {

            switch (browser.ToLower())
            {
                case "chrome":
                    SetChromeDriver();
                    break;

                case "edge":
                    SetEdgeDriver();
                    break;

                default:
                    SetFireFoxDriver();
                    break;
            }
        }

        public static void SetChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-popup-blocking");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--no-sandbox");

            chromeOptions.AddUserProfilePreference("download.default_directory", downloadPath);
            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);

            if (TestContext.Parameters["Headless"] == "true")
            {
                chromeOptions.AddArgument("--headless");
            }

            threadLocal.Value = new ChromeDriver(chromeOptions);
        }

        public static void SetEdgeDriver()
        {
            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--start-maximized");
            edgeOptions.AddArgument("--disable-notifications");
            edgeOptions.AddArgument("--disable-extensions");
            edgeOptions.AddArgument("--disable-popup-blocking");
            edgeOptions.AddArgument("--disable-gpu");
            //edgeOptions.AddArgument("--incognito");
            edgeOptions.AddArgument("--no-sandbox");

            edgeOptions.AddUserProfilePreference("download.default_directory", downloadPath);
            edgeOptions.AddUserProfilePreference("download.prompt_for_download", false);

            if (TestContext.Parameters["Headless"] == "true")
            {
                edgeOptions.AddArgument("--headless");

            }

            threadLocal.Value = new EdgeDriver(edgeOptions);           
        }

        public static void SetFireFoxDriver()
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

            threadLocal.Value  = new FirefoxDriver(fireFoxOptions);
        }

        public static WebDriver GetDriver()
        {
            return threadLocal.Value;
        }

        public static void Quit()
        {
            threadLocal.Value.Quit();
            threadLocal.Value.Dispose();
        }
    }
}