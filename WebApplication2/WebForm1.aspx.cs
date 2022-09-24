using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("nameTextBox")).Text;

            SqlDataSource1.InsertParameters["class"].DefaultValue =
              ((DropDownList)GridView1.FooterRow.FindControl("ClassList1")).Text;

            int a = SqlDataSource1.Insert();
        }
    }
}