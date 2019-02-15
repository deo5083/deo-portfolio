using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Skill
    {
        private string skill;
        private string level;
        private string skillType;
        private string numProjects;

        public Skill(string skill, string level, string skillType, string num)
        {
            this.skill = skill;
            this.level = level;
            this.skillType = skillType;
            this.numProjects = num;
        }

        public string getSkill()
        {
            return this.skill;
        }
        public string getLevel()
        {
            return this.level;
        }
        public string getSkillType()
        {
            return this.skillType;
        }
        public string getNumProjects()
        {
            return this.numProjects;
        }
    }
}