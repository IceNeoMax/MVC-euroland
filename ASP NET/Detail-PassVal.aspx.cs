using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Detail_PassVal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox obj = new TextBox();
        obj = (TextBox)Page.PreviousPage.FindControl("TextBox1");
        Response.Write(obj.Text);
    }
}