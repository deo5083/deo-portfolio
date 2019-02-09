using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;


namespace WebApplication2.Models
{
    public class Storage
    {
        private List<Degree> degreeList;
        private List<Course> courseList;


        public Storage(string degreesPath, string coursesPath)
        {
            degreeList = readDegreesTextFile(degreesPath);
            courseList = readCoursesTextFile(coursesPath);

        }
        
        public List<Degree> getDegreeList()
        {
            return this.degreeList;
        }

        public List<Course> getCoursesList()
        {
            return this.courseList;
        }
        
        private List<Course> readCoursesTextFile(string path)
        {
            List<Course> tempList = new List<Course>();

            string line;
            string[] coursesString = { };

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            
            while ((line = file.ReadLine()) != null)
            {
                coursesString = line.Split('~');

                string degree = coursesString[0];
                string[] words = coursesString[1].Split(';');

                

                foreach (string course in words)
                {
                    Course tempCourse = new Course(degree, course);
                    tempList.Add(tempCourse);
                }
                
            }

            file.Close();

            return tempList;
        }

        private List<Degree> readDegreesTextFile(string path)
        {
            List<Degree> tempList = new List<Degree>();
            
            string line;
             
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(';');
                
                Degree tempDegree = new Degree(words[0], words[1], words[2], words[3], words[4], words[5]);

                tempList.Add(tempDegree);
                
            }

            file.Close();
            
            return tempList;
        }

    }
}