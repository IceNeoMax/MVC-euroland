using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Ma la: " + Request.QueryString["Ma"] + "<br>" + "Ten la: " + Request.QueryString["Ten"] + "<br>" + "Tuoi la: " + Request.QueryString["Tuoi"]);
    }
}