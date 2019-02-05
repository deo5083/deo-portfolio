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
        

        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenButton_selectDegree.Style.Add("visibility", "hidden");

            string degreeFilePath = Server.MapPath("/App_Data/degrees.txt");

            storage = new Storage(degreeFilePath);
            degreeList = storage.getDegreeList();
            
            GenerateDivs(degreeList);
            
        }

        private void GenerateDivs(List<Degree> degreeList)
        {
            string div = "";

            foreach (Degree degree in degreeList)
            {

                string majopt = (degree.getMajor_option()).Replace(' ', '_');

                div += "<a href='#' class='list-group-item list-group-item-action flex-column align-items-start' onClick='selectClicked(\""+majopt+"\")'>" +
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


           

        }
        


    }
}