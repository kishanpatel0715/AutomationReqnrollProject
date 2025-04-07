using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationReqnrollProject.Pages
{
    class CSV_Verification_Page
    {
        public String getFilePath(String fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
        }
    }
}
