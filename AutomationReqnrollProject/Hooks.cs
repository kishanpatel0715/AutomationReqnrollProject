using AutomationReqnrollProject.Helper;
using OpenQA.Selenium;


namespace AutomationReqnrollProject
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks

        WebDriver driver;
        public Hooks() 
        {
            this.driver = Browser.getDriver();
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://go.reqnroll.net/doc-hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://go.reqnroll.net/doc-hooks#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenarioCloseBrowser()
        {
            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("Closing browser");
            driver.Quit();
           
        } 
    }
}