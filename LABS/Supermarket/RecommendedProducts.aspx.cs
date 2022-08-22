using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supermarket
{
    public partial class RecommendedProducts : System.Web.UI.Page
    {
        List<Products> _products = new List<Products>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Products"] == null)
            {
                ViewState["Products"] = _products;
            }
            else
            {
                _products = (List<Products>)ViewState["Products"];
            }
        }

        protected void lnkBtn_Click(object sender, EventArgs e)
        {
            _products.Add(new Products() { Name = txtModel.Text, DOM = txtManu.Text });
            lstUsers.DataSource = _products;
            lstUsers.DataTextField = "Name";
            lstUsers.DataValueField = "Name";
            lstUsers.DataBind();
            lstUsers.Visible = true;
            grdProducts.DataSource = _products;
            grdProducts.DataBind();
            ImageButton1.Visible = true;
            ViewState["Products"] = _products;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Billing");
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                grdProducts.Visible = false;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                grdProducts.Visible = true;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~WorkWithData");
        }
    }
}