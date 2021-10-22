using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Entities
{
    public class Users
    {
        [Key]
        public Guid UserId { get; set; }
        public string FullName { get; set; }
    }
}