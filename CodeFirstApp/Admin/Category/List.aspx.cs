using CodeFirstApp.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Admin.Category
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                CategoryList.DataSource = db.Categories.ToList();
                CategoryList.DataBind();
            }
        }
    }
}