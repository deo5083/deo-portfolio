using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Work> workList;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string workFilePath = Server.MapPath("/App_Data/work_exp.txt");
            Storage storage = new Storage(workFilePath);
            workList = storage.getWorkExp();

            GenerateDivs(this.workList);
            
        }

        private void GenerateDivs(List<Work> _workList)
        {
            string div = "";

            foreach (Work proj in _workList)
            {

                string id = proj.getCompany().Replace(' ', '_');

                string proj_arrayHTML = "";
                string skills = "";

                foreach (string li in proj.getProjects())
                {
                    proj_arrayHTML += "<li>"+li+"</li>";
                }
                bool isFirst = true;
                foreach (string li in proj.getSkills())
                {
                    if (isFirst)
                    {
                        skills += " " + li;
                        isFirst = false;
                    }
                    else
                    {
                        skills += " <span>&#8226;</span> " + li;
                    }
                }

                
                div += "<div class='exp_div bg-white rounded'>" +
                            "<h5 class='mb-1'>" +
                                "<span>"+proj.getTitle()+"</span>" +
                            "</h5>" +
                            "<p class='mb-1'>"+proj.getCompany()+"</p>" +
                            "<span class='text-muted small'>"+proj.getDates()+"</span>" +
                            "<p class='text-muted small'>"+proj.getLocation()+"</p>" +

                            "<ul>" +
                                proj_arrayHTML +
                            "</ul>" +

                            "<div class='text-center'>"+
                                "<span class='text-muted small'>"+ skills +"</span>"+
                            "</div>" +
                       "</div>"+
                       "<br>";
                
            }

            div_here.InnerHtml = div;
        }


    }
}