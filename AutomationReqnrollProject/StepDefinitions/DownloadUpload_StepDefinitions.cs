using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public class DownloadUpload_StepDefinitions
    {
        WebDriver driver;
        CommonMethods commonMethods;
        DownloadUpload_Page downloadUpload_Page;

        public DownloadUpload_StepDefinitions()
        {
            driver = Browser.driver;
            commonMethods = new CommonMethods();
            downloadUpload_Page = new DownloadUpload_Page();
        }

        [Given("User is on the Download and Upload page")]
        public void GivenUserIsOnTheDownloadAndUploadPage()
        {
            commonMethods.Visit("https://demoqa.com/upload-download");
        }

        [When("user downloads the file")]
        public void WhenUserDownloadsTheFile()
        {
            downloadUpload_Page.Download();
        }

        [Then("file is downloaded successfully")]
        public void ThenFileIsDownloadedSuccessfully()
        {
            bool isFileExist = File.Exists(Path.Combine(Path.GetFullPath(TestContext.Parameters["DownloadPath"]),"sampleFile.jpeg"));

            Assert.True(isFileExist, "File is not downloaded");
        }

        [When("user uploads the file")]
        public void WhenUserUploadsTheFile()
        {
            downloadUpload_Page.Upload();
        }

        [Then("file is uploaded successfully")]
        public void ThenFileIsUploadedSuccessfully()
        {
            Assert.That(downloadUpload_Page.UploadedFileName.Contains("Kohli.png"), "File is not uploaded");
        }
    }
}