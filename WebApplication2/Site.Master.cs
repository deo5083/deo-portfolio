using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setActiveHeader(Request.Path.ToLower());


        }
        
        private void setActiveHeader(string page)
        {
            if (page.EndsWith("default.aspx"))
            {
                overview.CssClass += " custom_active active";
           
            }
            
            else if (page.EndsWith("education.aspx"))
            {
                education.CssClass += " custom_active active";
                
            }
            else if (page.EndsWith("experience.aspx"))
            {
                experience.CssClass += " custom_active active";
              
            }
            else if (page.EndsWith("skills.aspx"))
            {
                skills.CssClass += " custom_active active";
              
            }
            
        }
    }
}