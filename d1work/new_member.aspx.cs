using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class new_member : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(IsPostBack)
        {
            SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\memberdb.mdf;Integrated Security=True");

            SqlCommand dbcmd = dbconn.CreateCommand();

            dbcmd.CommandText = "INSERT INTO [Member](Account, Password, name) VALUES(@Account, @Password, @name)";
            //參數
            
            dbcmd.Parameters.AddWithValue("@Account", Request["Account"]);
            dbcmd.Parameters.AddWithValue("@Password", Request["Password"]);
            dbcmd.Parameters.AddWithValue("@name", Request["name"]);

            dbconn.Open();

            dbcmd.ExecuteNonQuery();
            Response.Redirect("member_list.aspx");

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}