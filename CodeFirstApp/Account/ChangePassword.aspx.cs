using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Account
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("/Login");
            }
        }

        protected void BtnNewPassword_Click(object sender, EventArgs e)
        {
            string current = CurrentPassword.Text.Trim();
            string newpassword = NewPassword.Text.Trim();
            string confirmnew = ConfirmNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(current))
            {
                ErrorMesage.Text = "Enter your current password";
                return;
            }
            if (string.IsNullOrEmpty(newpassword))
            {
                ErrorMesage.Text = "Enter your new password";
                return;
            }
            if (string.IsNullOrEmpty(confirmnew))
            {
                ErrorMesage.Text = "Re-enter your new password";
                return;
            }

            MembershipUser user = Membership.GetUser();

            if (user != null)
            {
                user.ChangePassword(current,newpassword);
                ErrorMesage.Text = "Your password has been changed";
            }
        }
    }
}