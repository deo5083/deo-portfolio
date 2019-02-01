using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Models
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Resume_Click(object sender, EventArgs e)
        {
            TestSavedPDF("Resume_DavidOrtiz.pdf");
        }

        private void TestSavedPDF(string path)
        {
            WebClient User = new WebClient();

            Byte[] FileBuffer = User.DownloadData(path);

            if (FileBuffer != null)

            {
                Response.ContentType = "application/pdf";

                Response.AddHeader("content-length", FileBuffer.Length.ToString());

                Response.BinaryWrite(FileBuffer);
            }
        }
    }
}