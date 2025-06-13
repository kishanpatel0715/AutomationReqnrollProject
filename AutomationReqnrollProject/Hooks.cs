using AutomationReqnrollProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AutomationReqnrollProject
{
    [Binding]
    public sealed class Hooks
    {
        WebDriver driver;
        ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext scenarioContext)
        {
            this.driver = Browser.GetDriver(TestContext.Parameters["Browser"]);
            _scenarioContext = scenarioContext;
        } 

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenarioCloseBrowser()
        {
            //TODO: implement logic that has to run after executing each scenario
            driver.Quit();
        }

        [AfterStep]
        public void AfterFailedStepTakeScreenshot()
        {
            if (_scenarioContext.TestError != null) 
            {
                ITakesScreenshot takeScreenshot = (ITakesScreenshot)driver;
                Screenshot screenShot = takeScreenshot.GetScreenshot();

                string screenshotDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");

                if (!Directory.Exists(screenshotDirectory))
                {
                    Directory.CreateDirectory(screenshotDirectory);
                }

                string screenshotName = TestContext.CurrentContext.Test.Name.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                string filePath = Path.Combine(screenshotDirectory, screenshotName);
                screenShot.SaveAsFile(filePath);
            }
        }
    }
}