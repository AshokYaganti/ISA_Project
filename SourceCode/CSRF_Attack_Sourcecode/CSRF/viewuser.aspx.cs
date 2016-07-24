using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class viewuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["userid"] != null)
        {
            DataSet dset = new DataSet();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyExpConnectionString"].ToString());
            using (conn)
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlQuery = string.Format("SELECT name FROM user_info WHERE userID={0}", Request.QueryString["userid"]);
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.CommandType = CommandType.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(dset);
                if (dset.Tables[0].Rows.Count > 0)
                {
                    lblDetails.Text = dset.Tables[0].Rows[0]["name"].ToString(); ;
                }
                
            }
        }
    }
}