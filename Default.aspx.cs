using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StoredProcedureProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6FSF5UG\\SQLEXPRESS01;Initial Catalog=FYMCA_SEM2; Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("Select_Simple_StoredProcedure1 ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            Label4.Text = " All users are: ";
            while (dr.Read())
                Label4.Text += dr[0].ToString() + "\n ";
            dr.Close();
            cn.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6FSF5UG\\SQLEXPRESS01;Initial Catalog=FYMCA_SEM2;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("All_Operation_StoredProcedure", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Insert");
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Age", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Country", TextBox3.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            // GridView1.DataSource = SqlDataSource1;
            GridView1.Visible = true;
            GridView1.DataBind();
            cn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6FSF5UG\\SQLEXPRESS01;Initial Catalog=FYMCA_SEM2;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("All_Operation_StoredProcedure", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Update");
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Age", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Country", TextBox3.Text);
            //GridView1.DataSource = SqlDataSource1;

            cn.Open();
            cmd.ExecuteNonQuery();
            GridView1.Visible = true;
            GridView1.DataBind();
            cn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6FSF5UG\\SQLEXPRESS01;Initial Catalog=FYMCA_SEM2;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("All_Operation_StoredProcedure", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Delete");
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Age", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Country", TextBox3.Text);
            //GridView1.DataSource = SqlDataSource1;
            cn.Open();
            cmd.ExecuteNonQuery();
            GridView1.Visible = true;
            GridView1.DataBind();
            cn.Close();
        }
    }
}