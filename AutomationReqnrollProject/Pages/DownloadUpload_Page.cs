using AutomationReqnrollProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V132.Debugger;

namespace AutomationReqnrollProject.Pages
{
    class DownloadUpload_Page
    {

        WebDriver driver;

        public DownloadUpload_Page()
        {
            driver = Browser.driver;
        }

        By DownloadElement = By.LinkText("Download");
        By UploadElement = By.CssSelector("input[type=file]");
        By UploadedFileNameElement = By.Id("uploadedFilePath");


        public void Download()
        {
            driver.FindElement(DownloadElement).Click();
            DownloadHelper.WaitForDownload("sampleFile.jpeg");
        }

        public void Upload()
        {
            driver.FindElement(UploadElement).SendKeys(Path.Combine(Path.GetFullPath(TestContext.Parameters["UploadPath"]), "Kohli.png"));
        }

        public string UploadedFileName
        {
            get => driver.FindElement(UploadedFileNameElement).Text;
        }
    }
}