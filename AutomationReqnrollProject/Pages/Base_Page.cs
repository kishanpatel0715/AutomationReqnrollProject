namespace AutomationReqnrollProject.Pages
{
    class Base_Page
    {
        public String GetFilePath(String fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
        }
    }
}