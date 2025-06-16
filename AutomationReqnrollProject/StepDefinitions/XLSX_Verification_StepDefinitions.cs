using AutomationReqnrollProject.Pages;
using NUnit.Framework;
using OfficeOpenXml;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    public class XLSX_Verification_StepDefinitions
    {
        Base_Page base_Page;
        public XLSX_Verification_StepDefinitions()
        {
            base_Page = new Base_Page();
        }

        [Then("data of {string} xlsx file is matched with {string} xlsx file data")]
        public void ThenDataOfXlsxFileIsMatchedWithXlsxFileData(string actualFile, string expectedFile)
        {
            String actualFilePath = base_Page.GetFilePath(actualFile);
            String expectedFilePath = base_Page.GetFilePath(expectedFile);

            ExcelWorkbook actualWorkBook = new ExcelPackage(new FileInfo(actualFilePath)).Workbook;
            ExcelWorkbook expectedWorkBook = new ExcelPackage(new FileInfo(expectedFilePath)).Workbook;

            Assert.That(actualWorkBook.Worksheets.Count, Is.EqualTo(expectedWorkBook.Worksheets.Count), "Total number of worksheets have mismatch");


            for (int i=0; i< expectedWorkBook.Worksheets.Count; i++)
            {
                Assert.That(actualWorkBook.Worksheets[i].Dimension.Rows, Is.EqualTo(expectedWorkBook.Worksheets[i].Dimension.Rows), "Total number of rows have mismatch");
                Assert.That(actualWorkBook.Worksheets[i].Dimension.Columns, Is.EqualTo(expectedWorkBook.Worksheets[i].Dimension.Columns), "Total number of columns have mismatch");


                for (int j=1; j<= expectedWorkBook.Worksheets[i].Dimension.Rows; j++)
                {
                    for (int k=1; k<= expectedWorkBook.Worksheets[i].Dimension.Columns; k++)
                    {
                        Assert.That(actualWorkBook.Worksheets[i].Cells[j, k].Value.ToString(), Is.EqualTo(expectedWorkBook.Worksheets[i].Cells[j, k].Value.ToString()), $"Value is incorrect at Row {j} Column {k}");
                    }
                }
            }
        }
    }
}