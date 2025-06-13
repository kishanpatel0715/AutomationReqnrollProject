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

            Assert.AreEqual(expectedWorkBook.Worksheets.Count, actualWorkBook.Worksheets.Count, "Total number of worksheets have mismatch");


            for (int i=0; i< expectedWorkBook.Worksheets.Count; i++)
            {
                Assert.AreEqual(expectedWorkBook.Worksheets[i].Dimension.Rows, actualWorkBook.Worksheets[i].Dimension.Rows, "Total number of rows have mismatch");
                Assert.AreEqual(expectedWorkBook.Worksheets[i].Dimension.Columns, actualWorkBook.Worksheets[i].Dimension.Columns, "Total number of columns have mismatch");


                for (int j=1; j<= expectedWorkBook.Worksheets[i].Dimension.Rows; j++)
                {
                    for (int k=1; k<= expectedWorkBook.Worksheets[i].Dimension.Columns; k++)
                    {
                        Assert.AreEqual(expectedWorkBook.Worksheets[i].Cells[j, k].Value.ToString(), actualWorkBook.Worksheets[i].Cells[j, k].Value.ToString(), $"Value is incorrect at Row {j} Column {k}");
                    }
                }
            }
        }
    }
}