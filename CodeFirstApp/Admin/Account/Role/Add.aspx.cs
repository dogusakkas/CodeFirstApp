using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Admin.Account.Role
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddRole(object sender, EventArgs e)
        {
            string roleName = NewRole.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                ErrorMessage.Text = "Please enter role name";
                return;
            }

            if (Roles.RoleExists(roleName) == false)
            {
                Roles.CreateRole(roleName);
                Response.Redirect("List.aspx");
            }

            else
            {
                ErrorMessage.Text = "This role already exists";
            }


        }
    }
}