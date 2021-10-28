using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Entities
{
    public class UserIdentity
    {
        public Guid UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}