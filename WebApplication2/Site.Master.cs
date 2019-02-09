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

        private void addCustomToAllLinks() //may not need this
        {
            overview.CssClass += " custom_link";
            education.CssClass += " custom_link";
            experience.CssClass += " custom_link";
            skills.CssClass += " custom_link";
        } 

        private void setActiveHeader(string page)
        {

            if (page.EndsWith("default.aspx"))
            {
                overview.CssClass += " custom_active active";
                //addCustomToAllLinks();
                //overview.CssClass.Replace("custom_li", " ");
            }
            
            else if (page.EndsWith("education.aspx"))
            {
                education.CssClass += " custom_active active";
                //addCustomToAllLinks();
                //education.CssClass.Replace("custom_li", " ");
            }
            else if (page.EndsWith("experience.aspx"))
            {
                experience.CssClass += " custom_active active";
                //addCustomToAllLinks();
                //experience.CssClass.Replace("custom_li", " ");
            }
            else if (page.EndsWith("skills.aspx"))
            {
                skills.CssClass += " custom_active active";
                //addCustomToAllLinks();
                //skills.CssClass.Replace("custom_li", " ");
            }
            
        }
    }
}