using CodeFirstApp.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Supplier
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadList();
            }
        }

        private void LoadList()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var list = from x in db.Suppliers.OrderBy(x => x.CompanyName).ToList()
                           select x;

                SupplierListView.DataSource = list;
                SupplierListView.DataBind();
            }
        }
    }
}