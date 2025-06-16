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
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

        }

        [BeforeScenario(Order = 1)]
        public void Setup()
        {
            Browser.SetDriver(TestContext.Parameters["Browser"]);
            this.driver = Browser.GetDriver();
        }

        [AfterScenario]
        public void AfterScenarioCloseBrowser()
        {
            Console.WriteLine($"Running scenario '{_scenarioContext.ScenarioInfo.Title}' on thread {Thread.CurrentThread.ManagedThreadId}");

            Browser.Quit();
        }

        [AfterStep]
        public void AfterFailedStepTakeScreenshot()
        {
            if (_scenarioContext.TestError != null)
            {
                    ITakesScreenshot takeScreenshot = (ITakesScreenshot)driver;
                    var screenShot = takeScreenshot.GetScreenshot();

                    string projectRoot = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;
                    string screenshotDirectory = Path.Combine(projectRoot, "Screenshot");

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