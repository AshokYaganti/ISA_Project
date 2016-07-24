using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class amount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Login.aspx");

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string uname = Request["uname"];
        string amount = Request["amount"];

        Response.Redirect("transfer.aspx?uname="+uname+"&amount="+amount);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("userhome.aspx");
    }
}