using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supermarket
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<Customer> _customers = new List<Customer>();

        protected void lgnBtn_Click(object sender, EventArgs e)
        {

            _customers.Add(new Customer() { Email = custEmail.Text, Password = custPw.Text });
            Label2.Text = "Registration Successful!";
            Label2.Visible = true;

            Response.Redirect("~/Dashboard");
        }
    }
}