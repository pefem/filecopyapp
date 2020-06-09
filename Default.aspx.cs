using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Microsoft.Ajax.Utilities;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "no files copied";

        }

        public void Transfer_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            Transfer();
        }

        public void Transfer()
        {
            
            var source = @"C:\#\#\Desktop\WebApplication1\folder1";
            var destination = @"C:\#\#\Desktop\WebApplication1\folder2";
            var sourcePath = " ";
            var targetPath = "";
            

            var fileNames = new[]
            {
                "philip.txt",
                "viki.txt",
                "liam.txt"
            };

            foreach (var fileName in fileNames)
            {
                sourcePath = Path.Combine(source, fileName);
                targetPath = Path.Combine(destination, fileName);

                File.Copy(sourcePath, targetPath, true);

            }

            var fileSource = Directory.GetFiles(@"C:\#\#\Desktop\WebApplication1\folder1");
            var targetSource = Directory.GetFiles(@"C:\#\#\Desktop\WebApplication1\folder2");


            if((fileSource.Length) == (targetSource.Length))
            {
                Label1.Text = "All files have been copied";
            }
            
            
            
            
            
            
        }
    }
}