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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"].ToString() != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    LoadCategoryByID(id);
                }
                else
                {
                    Response.Redirect("List.aspx");
                }
            }
        }

        private void LoadCategoryByID(int id)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                Categories category = (from x in db.Categories
                                       where x.CategoryID == id
                                       select x).FirstOrDefault<Categories>();

                if (category != null)
                {
                    TxtCategoryName.Text = category.CategoryName;
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());

                using (NorthwindContext db = new NorthwindContext())
                {
                    Categories category = (from x in db.Categories
                                           where x.CategoryID == id
                                           select x).FirstOrDefault<Categories>();

                    if (category != null)
                    {
                        category.CategoryName = TxtCategoryName.Text.Trim();
                    }
                    db.SaveChanges();

                    ErrorMessage.Text = "The category has been successfully updated.";
                }

            }
            else
            {
                Response.Redirect("ListCategory");
            }
        }
    }
}