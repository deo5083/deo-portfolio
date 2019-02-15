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
        List<Project> projectList;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string workFilePath = Server.MapPath("/App_Data/work_exp.txt");
            string projectFilePath = Server.MapPath("/App_Data/project_exp.txt");
            Storage storage = new Storage(workFilePath, projectFilePath, "");
            workList = storage.getWorkExp();
            projectList = storage.getProjects();

            GenerateOverviewSection(this.projectList, this.workList);
            GenerateFavoritesSection(this.projectList);

            GenerateWorkDivs(this.workList);
            GenerateProjectDivs(this.projectList);
            
        }

        private void GenerateFavoritesSection(List<Project> _projectList)
        {
            string favorites_html_div = "<ul>";
            
            foreach (Project proj in _projectList)
            {
                bool isFavorite = false;
                string id = proj.getItems()[0].Replace(' ', '_');

                if(id.Contains("swimming_pool") || id.Contains("hotel_booking") || id.Contains("multiphase_project"))
                {
                    isFavorite = true;
                }
                

                if (isFavorite)
                {
                    favorites_html_div += "<li> <a href='#" + id + "'>" + proj.getClassName() + "</a> </li>";

                }

                
            }
            favorites_html_div += "</ul>";

            favorites_div.InnerHtml = favorites_html_div;

        }

        private void GenerateOverviewSection(List<Project> _projectList, List<Work> _workList)
        {
            string overview_html_div = "<ul>";

            foreach (Work job in _workList)
            {
                string id = job.getCompany().Replace(' ', '_');

                overview_html_div += "<li> <a href='#" + id + "'>" + job.getCompany() + "</a> </li>";

            }
            overview_html_div += "</ul><hr><ul>";

            foreach (Project proj in _projectList)
            {
                string id = proj.getItems()[0].Replace(' ', '_');

                overview_html_div += "<li> <a href='#"+id+"'>"+proj.getClassName()+"</a> </li>" ;
                
            }
            overview_html_div += "</ul>";
            
            overview_div.InnerHtml = overview_html_div;
            
        }

        private void GenerateProjectDivs(List<Project> _projectList)
        {
            string div = "";

            foreach (Project proj in _projectList)
            {

                string id = proj.getItems()[0].Replace(' ', '_');

                string proj_ItemsHTML = "";
                string skills = "";

                foreach (string li in proj.getItems())
                {
                    proj_ItemsHTML += "<li>" + li + "</li>";
                }
                bool isFirst = true;
                foreach (string li in proj.getThingsLearned())
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
                  

                div += "<div class='exp_div bg-white rounded' id='"+ id + "'>" +
                            "<h5 class='mb-1'>" +
                                "<span>" + proj.getClassName() + "</span>" +
                            "</h5>" +
                            "<span class='mb-1'>" + proj.getSchool() + "</span>" +

                            "<p class='text-muted small'>" + proj.getDate() + "</p>" +
                            
                            "<ul>" +
                                proj_ItemsHTML +
                            "</ul>" +

                            "<div class='text-center'>" +
                                "<span class='text-muted small'>" + skills + "</span>" +
                            "</div>" +
                       "</div>" +
                       "<br>";

            }

            div_projectExp.InnerHtml = div;
        }

        private void GenerateWorkDivs(List<Work> _workList)
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

                
                div += "<div class='exp_div bg-white rounded' id='"+id+"'>" +
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

            div_workExp.InnerHtml = div;
        }


    }
}