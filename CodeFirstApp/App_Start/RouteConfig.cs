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