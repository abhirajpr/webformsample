using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Product
{
    public partial class Database : System.Web.UI.Page
    {

        private SqlConnection con= new SqlConnection("Data Source = SUYPC177; Initial Catalog = TestDB; Integrated Security = True");
       
        protected void Page_Load(object sender, EventArgs e)
        {
        //    string str = "select * from login";
        //    SqlDataAdapter adp = new SqlDataAdapter(str, con);
        //    DataSet set1 = new DataSet();
        //    adp.Fill(set1);
        //    GridView1.DataSource = set1.Tables[0];
        //    GridView1.DataBind();
        }

        




        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           
            try
            {


                int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
                SqlCommand cmd = new SqlCommand("DELETE FROM login WHERE id=" + Id + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch( Exception ex)
            {

            }
            finally
            {
                Response.Redirect("Database.aspx");
            }

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string ProductID = GridView1.DataKeys[e.RowIndex].Values["id"].ToString();
                string name = e.NewValues[0].ToString();
                string password = e.NewValues[1].ToString();
                string age = e.NewValues[2].ToString();
                con.Open();
                string sql = "update login set username='" + name + "', password = '" + password + "', age = '" + age + "' where id='" + ProductID + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //GridView1.EditIndex = -1;
                //FillGrid();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Response.Redirect("Database.aspx");
            }
        }
    }
}