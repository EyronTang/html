using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection dbconn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\memberdb.mdf;Integrated Security=True");

        SqlCommand dbcmd = dbconn.CreateCommand();

        dbcmd.CommandText = "SELECT * FROM [Member]" ;

        
        dbconn.Open();

        SqlDataReader dbReader = dbcmd.ExecuteReader();
        string s = "";
        while(dbReader.Read())
        {
            s += "<tr><td>" + dbReader["name"] + "</td><td>" + dbReader["Account"] + "</td><td>" + dbReader["Password"] + "<a href = 'member_edit.aspx?Id=" + dbReader["Id"] + "'>修改</a> <a href ='delete_member.aspx?Id=" +dbReader["Id"] + "'>刪除</a></td></tr>";
            Literal1.Text = s;
        }
        


    }
}