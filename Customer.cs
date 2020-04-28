using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixMeetWebSite.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }

        public List<Request> requests[];
    }
}