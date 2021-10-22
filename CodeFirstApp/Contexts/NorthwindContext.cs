using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CodeFirstApp.Entities;

namespace CodeFirstApp.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("NorthwindConnectionString")
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}