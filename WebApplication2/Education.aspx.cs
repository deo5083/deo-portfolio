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
            string degreeFilePath = Server.MapPath("/App_Data/degrees.txt");

            storage = new Storage(degreeFilePath);
            degreeList = storage.getDegreeList();

            PopulateGridView(degreeList);

            GenerateDivs(degreeList);

            //cards_div.InnerHtml = GenerateDivs(degreeList); 


        }

        private void GenerateDivs(List<Degree> degreeList)
        {
            string div = "";

            foreach (Degree degree in degreeList)
            {
                /*
                div += "<div class='card mb-3' style='width: 40rem;'>" +
                            "<div class='card-body'>" +
                                "<h5 class='card-title'>" + degree.getDegree_type() + " " + degree.getMajor() + " - " + degree.getMajor_option() + "</h5>" +
                                    "<p class='card-text'>With supporting text below as a natural lead-in to additional content.</p>" +
                                    "<p class='card-text'><small class='text-muted'>Last updated 3 mins ago</small></p>" +
                             "</div></div>";
*/

                div += "<a href = '#' class='list-group-item list-group-item-action flex-column align-items-start'>" +
                            "<div class='d-flex w-100 justify-content-between'>" +
                                "<h5 class='mb-1'>" + degree.getDegree_type() + " " + degree.getMajor() + " - " + degree.getMajor_option() + "</h5>" +
                            "</div>" +
                                "<p class='mb-1'>Donec id elit non mi porta gravida at eget metus.Maecenas sed diam eget risus varius blandit.</p>" +

                                "<small class='text-muted'>Last updated 3 mins ago</small></p>" +
                             
                             "</a>";

            
    



            }

            cards_div.InnerHtml = div;
            //return div;
        }

        private void PopulateGridView(List<Degree> degreeList)
        {


            GridView_Education.DataSource = degreeList;
            GridView_Education.DataBind();


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

    }
}