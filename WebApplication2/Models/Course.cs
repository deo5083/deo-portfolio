using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Course
    {
        public string degree { get; set; }
        public string courseName { get; set; }

        public Course(string degree, string courseName)
        {
            this.degree = degree;
            this.courseName = courseName;
        }

        public string getDegree()
        {
            return this.degree;
        }
        public string getCourseName()
        {
            return this.courseName;
        }
    }
}