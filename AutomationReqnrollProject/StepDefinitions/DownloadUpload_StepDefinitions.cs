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
        DownloadUpload_Page downloadUpload_Page;

        public DownloadUpload_StepDefinitions()
        {
            driver = Browser.driver;
            downloadUpload_Page = new DownloadUpload_Page();
        }

        [Given("user selects the Elements from menu")]
        public void GivenUserSelectsTheElementsFromMenu()
        {
            downloadUpload_Page.SelectElementsFromMenu();
        }

        [Given("user selects Upload and Download from sub-menu")]
        public void GivenUserSelectsUploadAndDownloadFromSub_Menu()
        {
            downloadUpload_Page.SelectDownloadAndUploadFromSubMenu();
        }

        [When("the user downloads the file")]
        public void WhenTheUserDownloadsTheFile()
        {
            downloadUpload_Page.Download();
        }

        [Then("the file is downloaded successfully")]
        public void ThenTheFileIsDownloadedSuccessfully()
        {
            bool isFileExist = File.Exists(Path.Combine(Path.GetFullPath(TestContext.Parameters["DownloadPath"]), "sampleFile.jpeg"));

            Assert.True(isFileExist, "File is not downloaded");
        }

        [When("the user uploads the file")]
        public void WhenTheUserUploadsTheFile()
        {
            downloadUpload_Page.Upload();
        }

        [Then("the file is uploaded successfully")]
        public void ThenTheFileIsUploadedSuccessfully()
        {
            Assert.That(downloadUpload_Page.UploadedFileName.Contains("Kohli.png"), "File is not uploaded");
        }
    }
}