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
                    ErrorMesage.Text = "Hatalı şifre";
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
                    ErrorMesage.Text = "Üyelik Oluşturuldu";
                    break;
                case MembershipCreateStatus.UserRejected:
                    break;
                default:
                    break;
            }
        }
    }
}