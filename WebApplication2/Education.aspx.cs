using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2
{
    public partial class Education : System.Web.UI.Page
    {
        Storage storage;
        List<Degree> degreeList;
        List<Course> courseList;

        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenButton_selectDegree.Style.Add("visibility", "hidden");
            
            string degreeFilePath = Server.MapPath("/App_Data/degrees.txt");
            string coursesFilePath = Server.MapPath("/App_Data/courses.txt");

            storage = new Storage(degreeFilePath, coursesFilePath);
            degreeList = storage.getDegreeList();
            courseList = storage.getCoursesList();

            GeneratePanels(degreeList, courseList);
            GenerateDivs(degreeList);
            
        }

        private bool IsMobileBrowser()
        {

            HttpBrowserCapabilities myBrowserCaps = Request.Browser;
            if (((System.Web.Configuration.HttpCapabilitiesBase)myBrowserCaps).IsMobileDevice)
            {
                return true;
            }
            else
            {
                return false;
            }
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('" + labelText + "');", true);
        }

        private void GeneratePanels(List<Degree> _degreeList, List<Course> _courseList)
        {
            string panelsHtml="";
            string div1Html="";
            string div2Html = "";

            foreach (Degree degree in _degreeList)
            {
                div1Html = "";
                div2Html = "";

                string major_option = degree.getMajor_option().Replace(" ", "_");

                int coursesPerDegree = 0;

                foreach (Course course in _courseList)
                {
                    if (course.getDegree().Equals(degree.getMajor_option()))
                    {
                        coursesPerDegree++;
                    }
                }

                int half = coursesPerDegree / 2;
                int count = 0;


                foreach (Course course in _courseList)
                {
                    if (course.getDegree().Equals(degree.getMajor_option()))
                    {

                        if (count<half)
                        {
                            div1Html += "<span>" + course.getCourseName() + "</span><br><br>";
                        } else
                        {
                            div2Html += "<span>" + course.getCourseName() + "</span><br><br>";
                        }

                        count++;
                        
                        
                    }
                }
                
                panelsHtml += "<div ID='Panel_" + major_option + "' class='row courseLists' style='display: none;'> " +
                                   "<div class='col-sm-6' id='relatedCoursesDivCol1'>" +
                                        div1Html +
                                   "</div>" +
                                   "<div class='col-sm-6' id='relatedCoursesDivCol2'>"+
                                        div2Html +
                                   "</div>" +
                              "</div>";

            }
            
            panels_here.InnerHtml = panelsHtml;

            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "text", "divClicked('"+ HiddenField_selectDegree.Value + "')", true);
            
        }

        private void GenerateRelatedCoursework(List<Course> courseList, string degree_clicked)
        {
            

            string html = "";
            string html2 = "";

            int count = 0;
            int classesMatch = 0;

            List<Course> tempList = new List<Course>();

            foreach (Course course in courseList)
            {
                if (course.getDegree().Equals(degree_clicked))
                {
                    tempList.Add(course);
                }
            }

            foreach (Course course in tempList.ToList())
            {
                if (course.getDegree().Equals(degree_clicked))
                {
                    tempList.Add(course);
                }
            }

            //Label1.Text = tempList.Count().ToString();
            //html += "<asp:Label runat='server' Text='" + course.getCourseName() + "'></asp:Label><hr />";


            //relatedCoursesDivCol1.InnerHtml = html;

        }

        private void GenerateDivs(List<Degree> degreeList)
        {
            string div = "";

            foreach (Degree degree in degreeList)
            {

                string majopt = (degree.getMajor_option()).Replace(' ', '_');

                div += "<a href='#' id='" + majopt + "' class='list-group-item list-group-item-action flex-column align-items-start custom_divs' onClick='selectClicked(this.id)'>" +
                            "<div class='d-flex w-100 justify-content-between'>" +
                                "<h5 class='mb-1'>" + degree.getSchool() + "</h5>" +
                            "</div>" +
                                "<p class='mb-1'>"+ degree.getMajor() +" - " + degree.getMajor_option() + "</p>" +
                                "<small class='text-muted'>Graduated "+degree.getGrad_date()+"</small></p>" +
                        "</a>";
                
                
            }

            cards_div.InnerHtml = div;

        }
        
        private static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        protected void HiddenButton_selectDegree_Click(object sender, EventArgs e)
        {
            string degree_clicked = HiddenField_selectDegree.Value;
            Panel_degreeInfo.Visible = true;
            Label_Type.Visible = true;

            foreach (Degree degree in degreeList)
            {
                string major_option = degree_clicked.Replace("_"," ");

                if (degree.getMajor_option().Equals(major_option))
                {
                    Label_Degree.Text = degree.getMajor() + ", " + degree.getMajor_option();
                    Label_school.Text = degree.getSchool();
                    Label_GPA.Text = degree.getGPA();
                    Label_gradDate.Text = degree.getGrad_date();
                    Label_Type.Text = degree.getDegree_type();
                }
                
            }


            //GenerateRelatedCoursework(courseList, degree_clicked.Replace("_", " "));






        }
        


    }
}