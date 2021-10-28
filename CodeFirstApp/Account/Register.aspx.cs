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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string fullname = FullName.Text.Trim();
            string email = Email.Text.Trim();
            string password = Password1.Text.Trim();
            string passwordagain = PasswordAgain.Text.Trim();

            MembershipCreateStatus status;

            MembershipUser user = Membership.CreateUser(email, password, email, null, null, true, out status);

            switch (status)
            {
                case MembershipCreateStatus.DuplicateEmail:
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    break;
                case MembershipCreateStatus.ProviderError:
                    break;
                case MembershipCreateStatus.Success:
                    ErrorMessage.Text = "Üyelik Oluşturuldu";
                    CreateUserData(user.ProviderUserKey.ToString());
                    SetRole(user.UserName);
                    Response.Redirect("/Login.aspx");
                    break;
                case MembershipCreateStatus.UserRejected:
                    break;
                default:
                    break;
            }
        }

        private void SetRole(string p)
        {
            if (Roles.IsUserInRole(p, "User") == false)
            {
                Roles.AddUserToRole(p, "User");
            }
        }

        private void CreateUserData(string v)
        {
            Users entity = new Users();
            entity.UserId = Guid.Parse(v);
            entity.FullName = FullName.Text.Trim();

            using (NorthwindContext db = new NorthwindContext())
            {
                db.Users.Add(entity);
                db.SaveChanges();
            }

        }
    }
}