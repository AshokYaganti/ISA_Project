using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
public partial class transfer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Login.aspx");

        }
        else
        {

            string uname = Request.QueryString["uname"];
            string amount = Request.QueryString["amount"];
            string username = Convert.ToString(Session["username"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_transfer", con);
            cmd.CommandText = "sp_transfer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@amount", amount);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Payment successful');window.location='amount.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Something went wrong with account creation')</script>", false);
                Response.Redirect(ResolveUrl("amount.aspx"));
            }

        }
    }
}