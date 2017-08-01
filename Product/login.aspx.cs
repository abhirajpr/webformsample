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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = TestDB; Integrated Security = True");
            Int32 verify;
            string query1 = "Select count(*) from login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();
            verify = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            if (verify > 0)
            {
                Response.Redirect("Database.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Username and Password')</script>");
            }
        }
    }
}