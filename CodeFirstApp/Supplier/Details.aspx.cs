using CodeFirstApp.Contexts;
using CodeFirstApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstApp.Supplier
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"];

            if (String.IsNullOrEmpty(ID) == false)
            {
                LoadSupplierDetails(ID);
            }
        }

        private void LoadSupplierDetails(string ID)
        {
            int id = int.Parse(ID);
            using (NorthwindContext db = new NorthwindContext())
            {
                var details = (from x in db.Suppliers
                               where x.SupplierID == id
                               select x).FirstOrDefault<Suppliers>();

                LblCompanyName.Text = details.CompanyName;
                LblContactName.Text = details.ContactName;
                LblAddress.Text = details.Address;
                LblCity.Text = details.City;
                LblPostalCode.Text = details.PostalCode;
                LblPhone.Text = details.Phone;
                LblHomePage.Text = details.HomePage;

            }
        }
    }
}