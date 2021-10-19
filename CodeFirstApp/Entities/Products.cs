using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Entities
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
    }
}