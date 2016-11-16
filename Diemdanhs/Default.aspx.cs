using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection myConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["strConn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Doc duoc cac gia tri cua GridView
        //Voi cac Component trong Template Fields dung Method FindControl
        RadioButton r1 = new RadioButton();
        RadioButton r2 = new RadioButton();
        RadioButton r3 = new RadioButton();
        myConn.Open();
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            string Giatri = string.Empty;
            r1 = (RadioButton)GridView1.Rows[i].Cells[3].FindControl("R1");
            r2 = (RadioButton)GridView1.Rows[i].Cells[3].FindControl("R2");
            r3 = (RadioButton)GridView1.Rows[i].Cells[3].FindControl("R3");
            if (r1.Checked)
            {
                Giatri = "1";
            }
            if (r2.Checked)
            {
                Giatri = "0.5";
            }
            if (r3.Checked)
            {
                Giatri = "0";
            }
            DateTime postingDate = DateTime.Now;
            string day= string.Format("{0:MM/dd/yyyy}", postingDate);

                SqlCommand myComm = new SqlCommand("Insert into Diemdanh values (@ma,@ngay,@giatri)", myConn);
                //SqlCommand myComm = new SqlCommand("Insert into Diemdanh values ('" + GridView1.Rows[i].Cells[0].Text + "','" + day + "','" + Giatri + "')", myConn);
                myComm.Parameters.AddWithValue("@ma", GridView1.Rows[i].Cells[0].Text);
                myComm.Parameters.AddWithValue("@ngay", day);
                myComm.Parameters.AddWithValue("@giatri", Giatri);
                Response.Write(myComm.CommandText);
                try
                {
                    myComm.ExecuteNonQuery();
                    Label1.Text = "Thanh cong !";
                }
                catch (SqlException ex)
                {

                    Response.Write(ex.Message);
                }

            }
            myConn.Close();

        }
    }
