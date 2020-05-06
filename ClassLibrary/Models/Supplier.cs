using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Supplier
    {
       // public int SupplierID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
       // public Address Address { get; set; }
       // public Category Category { get; set; }
        public int Radius { get; set; }
    }
}
