namespace AutomationReqnrollProject.Pages
{
    class Base_Page
    {
        public String getFilePath(String fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
        }
    }
}