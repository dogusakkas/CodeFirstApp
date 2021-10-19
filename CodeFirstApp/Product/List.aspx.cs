using CodeFirstApp.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Product
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["categoryID"] != null)
                {
                    int categoryID = int.Parse(Request.QueryString["categoryID"].ToString());
                    LoadProducts(categoryID);
                }
                else
                {
                    LoadProducts();
                }

            }
        }

        private void LoadProducts()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var productlist = (from x in db.Products
                                   select x).ToList();

                ListViewProduct.DataSource = productlist.OrderBy(a => a.ProductName);
                ListViewProduct.DataBind();
            }
        }

        private void LoadProducts(int categoryID)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var productlist = (from x in db.Products
                                   where x.CategoryID == categoryID
                                   select x).ToList();

                ListViewProduct.DataSource = productlist;
                ListViewProduct.DataBind();
            }
        }
    }
}