using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class userhome : System.Web.UI.Page
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
            string username = Convert.ToString(Session["username"]);
            string balance = string.Empty;
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_balance", con);
            cmd.CommandText = "sp_balance";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                balance = ds.Tables[0].Rows[0]["balance"].ToString();
               
            }
            Label1.Text = balance;
            Label1.Visible = true;

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("userhome.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("amount.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("logout.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("csrf.aspx");
    }
}