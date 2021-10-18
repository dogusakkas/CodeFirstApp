using CodeFirstApp.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Layout
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        private void LoadCategories()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var categorylist = db.Categories.ToList();
                {
                    RepeaterCategory.DataSource = categorylist;
                    RepeaterCategory.DataBind();
                }
            }
        }
    }
}