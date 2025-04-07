using AutomationReqnrollProject.Pages;
using NUnit.Framework;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public class CSV_Verification_StepDefinitions
    {
        CSV_Verification_Page cSV_Verification_Page;
        public CSV_Verification_StepDefinitions()
        {
            cSV_Verification_Page = new CSV_Verification_Page();
        }

        [Then("data of {string} file is matched with {string} file data")]
        public void ThenDataOfFileIsMatchedWithFileData(string actualCSV, string expectedCSV)
        {
            String actualFilePath = cSV_Verification_Page.getFilePath(actualCSV);
            String expectedFilePath = cSV_Verification_Page.getFilePath(expectedCSV);

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