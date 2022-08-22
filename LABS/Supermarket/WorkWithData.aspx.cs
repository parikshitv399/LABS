using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supermarket
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static List<Guid> ids = new List<Guid>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ids.Add(Guid.NewGuid());
            if (Cache["guids"] == null)
            {
                Cache.Insert("guids", ids, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero);
            }
            grdGuids.DataSource = ids;
            grdGuids.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(SqlDataSource1.InsertCommand);
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Name", txtBox1.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Producer", txtBox2.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Director", txtBox3.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Budget", txtBox4.Text));
            adapter.InsertCommand.Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesDb;Integrated Security=True");

            using (adapter.InsertCommand.Connection)
            {
                adapter.InsertCommand.Connection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
            }
            grdView.DataBind();
            ResetValue();
        }
        private void ResetValue()
        {
            txtBox1.Text = string.Empty; txtBox2.Text = string.Empty;
            txtBox3.Text = string.Empty; txtBox4.Text = string.Empty;
        }
    }
}