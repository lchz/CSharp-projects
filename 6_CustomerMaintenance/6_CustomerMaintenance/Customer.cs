using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CustomerMaintenance
{
    public class Customer
    {
        public Customer() { }
        public Customer(string firstName, string lastName, string email) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }

        public string GetDisplayText()
        {
            return $"{this.FirstName} {this.LastName}, {this.Email}";
        }
    }
}
