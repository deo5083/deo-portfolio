using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private List<Skill> skillsList;
        protected void Page_Load(object sender, EventArgs e)
        {
            string skillFilePath = Server.MapPath("/App_Data/skills.txt");
            Storage storage = new Storage(skillFilePath);

            skillsList = storage.getSkills();

            GenerateCards(skillsList);
        }

        private void GenerateCards(List<Skill> _skillList)
        {
            string cards_skill_html = "";
            string card_tools_html = "";
            string card_knowledge_html = "";


            
            foreach (Skill sk in _skillList)
            {
                
                string id = sk.getSkill().Replace(' ', '_');

                
                switch (sk.getSkillType())
                {
                    case "language":

                        cards_skill_html += "<div class='card text-center'>" +
                                    "<div class='card-body'>" +
                                        "<h5 class='card-title'>" + sk.getSkill() + "</h5>" +
                                        //"<p class='card-text'>" + sk.getNumProjects() + " projects</p>" +
                                "</div>" +
                                //"<div class='card-footer'>" +
                                //    "<small class='text-muted'>" + sk.getNumProjects() + " projects</small>" +
                                //"</div>" +
                            "</div>";

                        break;

                    case "platforms":

                        card_tools_html += "<div class='card text-center'>" +
                                    "<div class='card-body'>" +
                                        "<h5 class='card-title'>" + sk.getSkill() + "</h5>" +
                                        //"<p class='card-text'>" + sk.getNumProjects() + " projects</p>" +
                                "</div>" +
                                //"<div class='card-footer'>" +
                                //    "<small class='text-muted'>" + sk.getNumProjects() + " projects</small>" +
                                //"</div>" +
                            "</div>";

                        break; 

                    case "knowledge":

                        card_knowledge_html += "<div class='card text-center'>" +
                                    "<div class='card-body'>" +
                                        "<h5 class='card-title'>" + sk.getSkill() + "</h5>" +
                                        //"<p class='card-text'>" + sk.getNumProjects() + " projects</p>" +
                                "</div>" +
                                //"<div class='card-footer'>" +
                                //    "<small class='text-muted'>" + sk.getNumProjects() + " projects</small>" +
                                //"</div>" +
                            "</div>";

                        break;
                    default:
                        break;
                }

            }


            cards_skills_div.InnerHtml = cards_skill_html;
            cards_tools_div.InnerHtml = card_tools_html;
            cards_knowledge_div.InnerHtml = card_knowledge_html;

        }
    }
}