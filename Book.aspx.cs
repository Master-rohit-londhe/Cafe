using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Book : System.Web.UI.Page
{
    string cs;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label15.Text = "";
        cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\cafe\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection cn = new SqlConnection(cs);
 cn.Open();
 SqlCommand cmd = new SqlCommand("Insert book(fname,lname,email,phonno,ngust,devent,stime,price,payment)values(@fnm,@lnm,@em,@pn,@ng,@de,@st,@pr,@pm)", cn);
         cmd.Parameters.AddWithValue("@fnm",TextBox8.Text);
         cmd.Parameters.AddWithValue("@lnm", TextBox3.Text); 
         cmd.Parameters.AddWithValue("@em", TextBox2.Text);
         cmd.Parameters.AddWithValue("@pn", TextBox5.Text);
         cmd.Parameters.AddWithValue("@ng", TextBox6.Text);
         cmd.Parameters.AddWithValue("@de", TextBox4.Text);
         cmd.Parameters.AddWithValue("@st",DropDownList2.Text);
         cmd.Parameters.AddWithValue("@pr",DropDownList1.Text);
         cmd.Parameters.AddWithValue("@pm",RadioButton1.Text);
         cmd.ExecuteNonQuery();
         Label15.Text = "Record Added Successfully";

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox8.Text = "";
        TextBox3.Text = "";
        TextBox2.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox4.Text = "";
        DropDownList2.Text= "";
        DropDownList1.Text = "";
        RadioButton1.Text = "";

    }
}