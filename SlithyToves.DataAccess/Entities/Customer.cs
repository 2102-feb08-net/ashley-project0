using System;
using System.Collections.Generic;

#nullable disable

namespace SlithyToves.DataAccess
{
    public partial class Customer
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public Customer(int id, string firstName, string lastName) 
        {
            CustomerId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(int id, string firstName, string lastName, string phone, string email, string zip)
        {
            CustomerId = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Zip = zip;
        }

        
    }
}
