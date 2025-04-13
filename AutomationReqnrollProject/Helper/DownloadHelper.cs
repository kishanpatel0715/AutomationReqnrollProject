using NUnit.Framework;

namespace AutomationReqnrollProject.Helper
{
    class DownloadHelper
    {
        public static  void WaitForDownload(string fileName)
        {
            var fullDowlnloadedFilePath = Path.Combine(Path.GetFullPath(TestContext.Parameters["DownloadPath"]), fileName);

            for (int i = 0; i < 30; i++)
            {
                if (File.Exists(fullDowlnloadedFilePath))
                {
                    break;
                }
                else
                {
                    Thread.Sleep(10);
                }
            }
        }
    }
}