using CodeFirstApp.Contexts;
using CodeFirstApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Admin.Category
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] !=null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());

                using (NorthwindContext db = new NorthwindContext())
                {
                    var entity = (from x in db.Categories
                                 where x.CategoryID == id
                                 select x).FirstOrDefault<Categories>();

                    if (entity != null)
                    {
                        db.Categories.Remove(entity);
                        db.SaveChanges();
                        Response.Redirect("ListCategory");
                    }
                }
            }
            else
            {
                Response.Redirect("ListCategory");
            }
        }
    }
}