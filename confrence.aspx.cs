using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class confrence : System.Web.UI.Page
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
 SqlCommand cmd = new SqlCommand("Insert confrence(name,lname,emailid,phoneno,ngust,tableno,dcon,selecttime,price,payment)values(@nm,@lnm,@em,@pn,@ng,@tn,@dc,@st,@price,@paym)", cn);
 cmd.Parameters.AddWithValue("@nm",TextBox1.Text);
 cmd.Parameters.AddWithValue("@lnm", TextBox3.Text);
 cmd.Parameters.AddWithValue("@em", TextBox2.Text);
 cmd.Parameters.AddWithValue("@pn", TextBox5.Text);
 cmd.Parameters.AddWithValue("@ng", TextBox6.Text);
 cmd.Parameters.AddWithValue("@tn", DropDownList1.Text);
 cmd.Parameters.AddWithValue("@dc", TextBox4.Text);
 cmd.Parameters.AddWithValue("@st", DropDownList3.Text);
 cmd.Parameters.AddWithValue("@price",DropDownList2.Text);
 cmd.Parameters.AddWithValue("@paym", RadioButton1.Text);

 cmd.ExecuteNonQuery();
 Label15.Text = "Record Added Successfully";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox3.Text= "";
        TextBox2.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        DropDownList1.Text = "";
        TextBox4.Text = "";
        DropDownList3.Text = "";
        DropDownList2.Text = "";
       // RadioButton1.Text = "";
    }
}