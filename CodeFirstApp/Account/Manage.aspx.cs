using CodeFirstApp.Contexts;
using CodeFirstApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDetails();
            }
        }

        private void LoadDetails()
        {
            UserIdentity identity = (UserIdentity)Session["Useridentity"];

            

               
                    TxtFullName.Text = identity.FullName;
                    TxtEmail.Text = identity.Email;
                
            
        }

        

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string fullname = TxtFullName.Text.Trim();

            Users user = new Users();
            user.FullName = fullname;

            UserIdentity identity = (UserIdentity)Session["Useridentity"];

            using (NorthwindContext db = new NorthwindContext())
            {
                var CustomUser = (from x in db.Users
                            where x.UserId == identity.UserID
                              select x).FirstOrDefault<Users>();

                if (CustomUser != null)
                {
                    TxtEmail.Text = identity.Email;
                    TxtFullName.Text = identity.FullName;
                }
                db.SaveChanges();
                identity.FullName = fullname;
                Session["Useridentity"] = identity;
                SuccessfulMessage.Text = "Changes Saved";
            }
            
        }
    }
}