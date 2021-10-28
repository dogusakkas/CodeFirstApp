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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(TxtCategoryName.Text))
            {
                ErrorMessage.Text = "Please enter a category name";
                return;
            }

            Categories category = new Categories();
            category.CategoryName = TxtCategoryName.Text.Trim();

            using (NorthwindContext db = new NorthwindContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();

                ErrorMessage.Text = "The category has been successfully added.";
            }
        }
    }
}