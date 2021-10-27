using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace CodeFirstApp.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Home
            routes.MapPageRoute("HomeRoute","Home","~/Home.aspx");
            routes.MapPageRoute("RegisterRoute","Register", "~/Account/Register.aspx");
            routes.MapPageRoute("LoginRoute","Login", "~/Account/Login.aspx");
            routes.MapPageRoute("ProfileRoute","Profile", "~/Account/Manage.aspx");
            routes.MapPageRoute("LogoutRoute","Logout", "~/Account/Logout.aspx");
            routes.MapPageRoute("ChangePasswordRoute","ChangePassword", "~/Account/ChangePassword.aspx");
            // Account
            routes.MapPageRoute("UnauthorizeRoute", "Unauthorize", "~/Error/Unauthorize.aspx");
            // Product
            routes.MapPageRoute("ProductsRoute","Products","~/Product/List.aspx");
            routes.MapPageRoute("ProductRoute", "Product/{ProductName}", "~/Product/Details.aspx");
            // Category
            routes.MapPageRoute("ProductsByCategoryRoute", "Products/{CategoryName}", "~/Product/List.aspx");
            // Supplier
            routes.MapPageRoute("SuppliersRoute","Suppliers","~/Supplier/List.aspx");
            routes.MapPageRoute("SupplierRoute", "Supplier/{SupplierName}", "~/Supplier/Details.aspx");



        }
    }
}