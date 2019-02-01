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

        public Storage(string path)
        {
            degreeList = readDegreesTextFile(path);

        }
        

        public List<Degree> getDegreeList()
        {
            return this.degreeList;
        }
    
        //public void setDegreeFile(string path)
        //{
        //    this.degreePath = path;
        //}

        private List<Degree> readDegreesTextFile(string path)
        {
            List<Degree> tempList = new List<Degree>();
            
            string line;
            
            //string currentDirectory = Directory.GetCurrentDirectory();
            //string filePath = System.IO.Path.Combine(currentDirectory, "Models", "degrees.txt");

            // Read the file and display it line by line.  
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