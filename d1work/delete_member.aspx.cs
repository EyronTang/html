using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class delete_member : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\memberdb.mdf;Integrated Security=True");

            SqlCommand dbcmd = dbconn.CreateCommand();
            
            dbcmd.CommandText = "DELETE FROM Member WHERE Id = @Id AND Account = @Account AND Password = @Password";
            dbcmd.Parameters.AddWithValue("@Id", Request["Id"]);
            dbcmd.Parameters.AddWithValue("@Account", Request["Account"]);
            dbcmd.Parameters.AddWithValue("@Password", Request["Password"]);
            
            //差顯示條件未達成失敗字
            dbconn.Open();
            //SqlDataReader dbReader = dbcmd.ExecuteReader();
            dbcmd.ExecuteNonQuery();
            Response.Redirect("member_list.aspx");
            //差顯示條件未達成失敗字
            /*if (dbReader.Read())
            {
                dbcmd.ExecuteNonQuery();
                Response.Redirect("member_list.aspx");
            }
            else
            {
                Label1.Text = "登入失敗";
            }*/


        }
    }
}