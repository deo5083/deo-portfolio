using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Work
    {
        private string company;
        private string location;
        private string date_range;
        private string title;
        private string[] projects;
        private string[] skills;


        public Work(string company, string location, string date_range, string title, string[] proj_string, string[] skills)
        {
            this.company = company;
            this.location = location;
            this.date_range = date_range;
            this.title = title;
            this.projects = proj_string;
            this.skills = skills;
        }




        public string getCompany()
        {
            return this.company;
        }
        public string getLocation()
        {
            return this.location;
        }
        public string getDates()
        {
            return this.date_range;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string[] getProjects()
        {
            return this.projects;
        }
        public string[] getSkills()
        {
            return this.skills;
        }



    }
}