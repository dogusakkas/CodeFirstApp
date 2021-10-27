using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Admin.Account.Role
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            DataTable RoleList = new DataTable();

            RoleList.Columns.Add("RoleName");
            RoleList.Columns.Add("UserCount");

            string[] roles = Roles.GetAllRoles();

            foreach (var item in roles)
            {
                int userCount = Roles.GetUsersInRole(item).Length;
                string[] roleRow = { item, userCount.ToString() };

                RoleList.Rows.Add(roleRow);
            }
            UserRoles.DataSource = RoleList;
            UserRoles.DataBind();


        }

        protected void DeleteRole(object sender, CommandEventArgs e)
        {
            Roles.DeleteRole(e.CommandArgument.ToString());
            ErrorMessage.Text = string.Format("{0} Role deleted", e.CommandArgument.ToString());
        }

    }
}