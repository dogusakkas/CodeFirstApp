using CodeFirstApp.Contexts;
using CodeFirstApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Layout
{
    public partial class Page : System.Web.UI.MasterPage
    {

        public string UserName { get; set; }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                UserIdentity identity = new UserIdentity();

                if (Session["Useridentity"] == null)
                {
                    MembershipUser MembershipUser = LoadMembershipData();
                    Users customUser = LoadUserData(MembershipUser.ProviderUserKey.ToString());

                    identity.UserID = Guid.Parse(MembershipUser.ProviderUserKey.ToString());
                    identity.Email = MembershipUser.Email;
                    identity.FullName = customUser.FullName;

                    Session["Useridentity"] = identity;

                }
                else
                {
                    identity = (UserIdentity)Session["Useridentity"];
                }

                UserName = identity.FullName;
            }
        }

        private Users LoadUserData(string v)
        {
            Guid userIdd = Guid.Parse(v);
            Users entity = null;

            using (NorthwindContext db = new NorthwindContext())
            {
                entity = (from x in db.Users
                          where x.UserId == userIdd
                          select x).FirstOrDefault<Users>();
            }
            return entity;
        }

        private MembershipUser LoadMembershipData()
        {
            return Membership.GetUser();
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        private void LoadCategories()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var categorylist = db.Categories.ToList();
                {
                    RepeaterCategory.DataSource = categorylist;
                    RepeaterCategory.DataBind();
                }
            }
        }
    }
}