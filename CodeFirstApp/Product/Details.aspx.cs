using CodeFirstApp.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Product
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request.QueryString["id"];

            if (string.IsNullOrEmpty(Id) == false)
            {
                LoadProductDetails(Id);
            }
            else
            {
                Response.Redirect("List.aspx");
            }
        }

        private void LoadProductDetails(string Id)
        {
            int id = int.Parse(Id);
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from x in db.Products
                             where x.ProductID == id
                             select new
                             {
                                 x.ProductID,
                                 x.ProductName,
                                 x.UnitPrice,
                                 x.UnitsInStock
                             }).FirstOrDefault();

                LblProductName.Text = result.ProductName;
                LblUnitPrice.Text = result.UnitPrice.ToString();
                LblStock.Text = result.UnitsInStock.ToString();
            }
        }
    }
}