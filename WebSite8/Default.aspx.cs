using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;//Doc connection string trong web config

public partial class _Default : System.Web.UI.Page
{
    SqlConnection myConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["strConn"].ToString());
   
    SqlDataReader myReader;
    SqlCommand SelectCategory;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SelectCategory = new SqlCommand("Select * from Categories", myConn);
            
            myConn.Open();
            myReader = SelectCategory.ExecuteReader();
            while (myReader.Read())
            {
                DropDownList1.Items.Add(new ListItem(myReader[1].ToString(), myReader[0].ToString()));
            }
            myConn.Close();
        }
    }
   
}