using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Project
    {
        private string school;
        private string[] items;
        private string[] thingsLearned;
        private string dateRange;
        private string className;

        public Project(string school, string className, string[] items, string[] thingsLearned, string dateRange)
        {
            this.school = school;
            this.className = className;
            this.items = items;
            this.thingsLearned = thingsLearned;
            this.dateRange = dateRange;
        }

        public string getSchool()
        {
            return this.school;
        }
        public string getClassName()
        {
            return this.className;
        }
        public string[] getItems()
        {
            return this.items;
        }
        public string[] getThingsLearned()
        {
            return this.thingsLearned;
        }
        public string getDate()
        {
            return this.dateRange;
        }




    }
}