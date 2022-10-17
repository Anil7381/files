using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MiniProject; Integrated Security=SSPI");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter adp=new SqlDataAdapter();    
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        cmd.CommandText = "Select * from Users Where UserName='" + Textbox1.Text + "' and UserPassword='" + Textbox2.Text + "'";
        cmd.Connection = conn;
        conn.Open();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        conn.Close();
        if (dt.Rows.Count > 0)
        {
            Response.Write("UserId :"+dt.Rows[0][0].ToString());
            Response.Write("<br/>");
            Response.Write("UserName :"+dt.Rows[0][1].ToString());
            Response.Write("<br/>");
            Response.Write("UserPassword :" + dt.Rows[0][2].ToString());
            Response.Write("<br/>");
            Response.Write("UserAddress :" + dt.Rows[0][3].ToString());

        }
        else
        {
            Response.Write("Incorrect User login credentials");
        }

    }

    
}