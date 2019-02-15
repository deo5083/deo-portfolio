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
        private List<Work> workList;
        private List<Project> projectsList;
        private List<Skill> skillList;

        public Storage(string skillsPath)
        {
            skillList = readSkillsTextFile(skillsPath);
        }

        public Storage(string degreesPath, string coursesPath)
        {
            degreeList = readDegreesTextFile(degreesPath);
            courseList = readCoursesTextFile(coursesPath);

        }

        public Storage(string workPath, string projectPath, string isExp)
        {
            workList = readWorksTextFile(workPath);
            projectsList = readProjectsTextFile(projectPath);
        }
        
        public List<Degree> getDegreeList()
        {
            return this.degreeList;
        }

        public List<Course> getCoursesList()
        {
            return this.courseList;
        }

        public List<Work> getWorkExp()
        {
            return this.workList;
        }

        public List<Project> getProjects()
        {
            return this.projectsList;
        }

        public List<Skill> getSkills()
        {
            return this.skillList;
        }

        private List<Skill> readSkillsTextFile(string path)
        {
            List<Skill> tempList = new List<Skill>();
            
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                string[] strings = line.Split('~');
                string skill = strings[0];
                string level = strings[1];
                string type = strings[2];
                string projects = strings[3];

                Skill tempSkill = new Skill(skill, level, type, projects);
                tempList.Add(tempSkill);

            }

            file.Close();
            
            return tempList;
        }

        private List<Project> readProjectsTextFile(string path)
        {
            List<Project> tempList = new List<Project>();

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                string[] sections = line.Split(';');
                string school = sections[0].Split('~')[0];
                string className = sections[0].Split('~')[1];
                string[] items = sections[1].Split('~');
                string[] skillsArr = sections[2].Split('~');
                string date = sections[3];

                Project tempProject = new Project(school, className, items, skillsArr, date);
                tempList.Add(tempProject);

            }

            file.Close();

            return tempList;
        }

        private List<Work> readWorksTextFile(string path)
        {
            List<Work> tempList = new List<Work>();

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            
            while ((line = file.ReadLine()) != null)
            {

                string[] firstHalf = line.Split(';');

                string[] companyInfo = firstHalf[0].Split('~');

                string[] skillsArr = firstHalf[2].Split('~');

                Work temp = new Work(companyInfo[0], companyInfo[1], companyInfo[2], companyInfo[3], firstHalf[1].Split('~'), skillsArr);

                tempList.Add(temp);

            }

            file.Close();

            return tempList;
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