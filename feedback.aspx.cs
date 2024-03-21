using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class feedback : System.Web.UI.Page
{
    string cs;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label10.Text = "";
        cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\cafe\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection cn = new SqlConnection(cs);
        cn.Open();
        SqlCommand cmd = new SqlCommand("Insert Feedback(Name,Email,Address,Gender,Sati,Message)values(@nm,@email,@add,@gen,@sati,@message)", cn);
        cmd.Parameters.AddWithValue("@nm",TextBox1.Text);
        cmd.Parameters.AddWithValue("@email",TextBox2.Text);
        cmd.Parameters.AddWithValue("@add",TextBox3.Text);
        cmd.Parameters.AddWithValue("@gen",RadioButton1.Text);
        cmd.Parameters.AddWithValue("@sati",RadioButton3.Text );
        cmd.Parameters.AddWithValue("@message",TextBox4.Text );
        cmd.ExecuteNonQuery();
        Label10.Text = "Record Added Successfully";
    }
}