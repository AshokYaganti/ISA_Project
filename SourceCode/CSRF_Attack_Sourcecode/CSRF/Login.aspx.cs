using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;

        if ((username == "yaganti123") && (password == "P@ssw0rd"))
        {
            Session["username"] = username;
            Response.Redirect("userhome.aspx");
        }
        else
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Invalid Credentials' )</script>", false);
        }
    }
}