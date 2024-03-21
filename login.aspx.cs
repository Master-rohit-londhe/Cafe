using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    string cs;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label8.Text = "";
        cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\cafe\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection cn = new SqlConnection(cs);
        cn.Open();
        SqlCommand cmd = new SqlCommand("Insert into Login(Uname,Password)values(@unm,@pwd)", cn);
        cmd.Parameters.AddWithValue("@unm",TextBox1.Text);
        cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);
        cmd.ExecuteNonQuery();
        Label8.Text = "Record Added Successfully";
    }
}