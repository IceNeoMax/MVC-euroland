using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("cai nay trong pageload");
        LblHello.Text = "Hello";
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("asd");
            DropDownList1.Items.Add("asds");
            DropDownList1.Items.Add("asbd");
        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Detail.aspx?Ma=1&Ten=Tu");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ButtonChuyenTrang_Click(object sender, EventArgs e)
    {
        Response.Redirect("Detail.aspx?Ma="+TextBox1.Text+"&Ten="+TextBox2.Text+"&Tuoi="+TextBox3.Text);
    }
    protected void PassVal_Click(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
}