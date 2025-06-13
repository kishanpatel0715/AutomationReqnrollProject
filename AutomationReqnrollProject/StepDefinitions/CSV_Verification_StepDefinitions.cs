using AutomationReqnrollProject.Pages;
using NUnit.Framework;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public class CSV_Verification_StepDefinitions
    {
        Base_Page base_Page;
        public CSV_Verification_StepDefinitions()
        {
            base_Page = new Base_Page();
        }

        [Then("data of {string} file is matched with {string} file data")]
        public void ThenDataOfFileIsMatchedWithFileData(string actualCSV, string expectedCSV)
        {
            String actualFilePath = base_Page.GetFilePath(actualCSV);
            String expectedFilePath = base_Page.GetFilePath(expectedCSV);

            String[] actualLinesData = File.ReadAllLines(actualFilePath);
            String[] expectedLinesData = File.ReadAllLines(expectedFilePath);

           Assert.AreEqual(expectedLinesData.Length, actualLinesData.Length, "Total number of rows have mismatch");

            for (int i=0; i< expectedLinesData.Length; i++)
            {
                String[] expectedValue = expectedLinesData[i].Split(",");
                String[] actualValue = actualLinesData[i].Split(",");

                Assert.AreEqual(expectedValue.Length, actualValue.Length, "Total number of columns have mismatch");

                for ( int j=0; j< expectedValue.Length; j++)
                {
                    //Assert.That(actualValue[j].Equals(expectedValue[j]),$"Value is incorrect at Row {i+1} Column {j+1}");
                    Assert.AreEqual(expectedValue[j], actualValue[j], $"Value is incorrect at Row {i + 1} Column {j + 1}");

                }
            }
        }
    }
}