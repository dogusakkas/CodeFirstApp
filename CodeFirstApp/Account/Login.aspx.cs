using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Response.Redirect("/Home");
            }
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                ErrorMessage.Text = "Email cannot be empty";
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                ErrorMessage.Text = "Password cannot be empty";
                return;
            }

            if (Membership.ValidateUser(email, password))
            {
                FormsAuthentication.RedirectFromLoginPage(email, true);
            }
            else
            {
                ErrorMessage.Text = "Email or password incorrect please try again";
            }
        }
    }
}