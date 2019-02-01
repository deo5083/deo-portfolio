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