using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class singup : System.Web.UI.Page
{
    string cs;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label9.Text = "";
        cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\cafe\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection cn = new SqlConnection(cs);
        cn.Open();
   SqlCommand cmd = new SqlCommand("Insert singup(Name,pass,conpass,address,moblieno,emailid)values(@nm,@pass,@conpass,@add,@mobno,@emailid)", cn);
   cmd.Parameters.AddWithValue("@nm",TextBox1.Text);
   cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
   cmd.Parameters.AddWithValue("@conpass", TextBox3.Text);
   cmd.Parameters.AddWithValue("@add", TextBox4.Text);
   cmd.Parameters.AddWithValue("@mobno", TextBox5.Text);
   cmd.Parameters.AddWithValue("@emailid", TextBox6.Text);

   cmd.ExecuteNonQuery();
   Label9.Text = "Record Added Successfully";
    }
}