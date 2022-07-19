using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\memberdb.mdf;Integrated Security=True");

            dbconn.Open();

            SqlCommand dbcmd = dbconn.CreateCommand();
            
            //參數
            dbcmd.CommandText = "SELECT *FROM [Member] WHERE Id = @Id";
            dbcmd.Parameters.AddWithValue("Id", Request["Id"]);

            SqlDataReader dbReader = dbcmd.ExecuteReader();

            if(dbReader.Read())
            {
                Account.Text = dbReader["Account"].ToString();
                Password.Text = dbReader["Password"].ToString();
                Name.Text = dbReader["name"].ToString();
            }
           
            //Response.Redirect("member_list.aspx");

        }
        else
        {
            SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\memberdb.mdf;Integrated Security=True");

            dbconn.Open();

            SqlCommand dbcmd = dbconn.CreateCommand();
            dbcmd.CommandText = "UPDATE [Member] set Account =@Account, Password = @Password, name = @name WHERE Id = @Id";

            dbcmd.Parameters.AddWithValue("@Id", Request["Id"]);
            dbcmd.Parameters.AddWithValue("@Account", Request["Account"]);
            dbcmd.Parameters.AddWithValue("@Password", Request["Password"]);
            dbcmd.Parameters.AddWithValue("@name", Request["name"]);

            

            dbcmd.ExecuteNonQuery();
            Response.Redirect("member_list.aspx");
        }
    }
}