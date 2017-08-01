using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = TestDB; Integrated Security = True");


            SqlCommand cmd = new SqlCommand("insert into login(username,password,age) values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con);

            cmd.CommandType = CommandType.Text;


            con.Open();

            cmd.ExecuteNonQuery();



            con.Close();
        }
    }
}