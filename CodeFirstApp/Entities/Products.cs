using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Entities
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public uint UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
    }
}