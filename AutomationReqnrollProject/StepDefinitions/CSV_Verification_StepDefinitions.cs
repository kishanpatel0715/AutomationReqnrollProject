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

            Assert.That(actualLinesData.Length, Is.EqualTo(expectedLinesData.Length), "Total number of rows have mismatch");

            for (int i=0; i< expectedLinesData.Length; i++)
            {
                String[] expectedValue = expectedLinesData[i].Split(",");
                String[] actualValue = actualLinesData[i].Split(",");

                Assert.That(actualValue.Length, Is.EqualTo(expectedValue.Length), "Total number of columns have mismatch");

                for ( int j=0; j< expectedValue.Length; j++)
                {
                    Assert.That(actualValue[j], Is.EqualTo(expectedValue[j]), $"Value is incorrect at Row {i + 1} Column {j + 1}");

                }
            }
        }
    }
}