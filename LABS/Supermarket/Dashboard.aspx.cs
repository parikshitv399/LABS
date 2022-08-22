using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supermarket
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RecommendedProducts");
        }
    }
}