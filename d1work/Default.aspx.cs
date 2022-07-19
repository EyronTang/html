using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       // string acc = Request["account"];
       // string pwd = Request["password"];


        //SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\H107B131\\database\\database\\App_Data\\memberdb.mdf;Integrated Security=True");
        SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\memberdb.mdf;Integrated Security=True");

        SqlCommand dbcmd = dbconn.CreateCommand();

        dbcmd.CommandText = "SELECT * FROM [Member] WHERE Account = @account AND Password = @password";

        //參數
        dbcmd.Parameters.AddWithValue("account", Request["account"]);
        dbcmd.Parameters.AddWithValue("password", Request["password"]);

        dbconn.Open();

        SqlDataReader dbReader = dbcmd.ExecuteReader();

        
        if(dbReader.Read())
        {
            Response.Redirect("member_list.aspx");  
        }
        else
        {
            Label1.Text = "登入失敗";
        }
        //if(acc == "aaa" && pwd == "123")
        //{
        //    //Label1.Text = "成功";
        //    Response.Redirect("member_list.aspx");
        //}
        //else
        //{
        //    Label1.Text = "失敗";
        //}
    }
}