using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Degree
    {
        public string school { get; set; }
        public string degree_type { get; set; }
        public string major { get; set; }
        public string major_option { get; set; }
        public string gpa { get; set; }
        public string grad_date { get; set; }

        public Degree(string school, string degree_type, string major, string major_option, string gpa, string grad_date)
        {
            this.school = school;
            this.degree_type = degree_type;
            this.major = major;
            this.major_option = major_option;
            this.gpa = gpa;
            this.grad_date = grad_date;
        }

        public string getSchool()
        {
            return this.school;
        }
        public string getDegree_type()
        {
            return this.degree_type;
        }
        public string getMajor()
        {
            return this.major;
        }
        public string getMajor_option()
        {
            return this.major_option;
        }
        public string getGPA()
        {
            return this.gpa;
        }
        public string getGrad_date()
        {
            return this.grad_date;
        }
        



    }
}