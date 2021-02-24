using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections;
using SlithyToves.Library;

namespace SlithyToves.DataAccess
{
    public class Repository
    {
        private readonly SlithyTovesContext _dbContext;

        public Repository(SlithyTovesContext context) 
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));
        }

        public Library.Models.CustomerModel GetCustomerById(int id)
        {
            var result = _dbContext.Customers.Where(x => x.CustomerId == id).First();
            Library.Models.CustomerModel customer = 
                new Library.Models.CustomerModel(result.FirstName, result.LastName, result.CustomerId);
            Console.WriteLine($"\n\nCustomer ID: {customer.CustomerId}\nName: {customer.FirstName} {customer.LastName}\nPhone: {customer.Phone}\nEmail: {customer.Email}\nZip: {customer.Zip}");
            return customer;

            // Customer customer = _dbContext.Customers.Find(id);
            // return new Library.Models.CustomerModel
            // {
            //     FirstName = customer.FirstName,
            //     LastName = customer.LastName,
            //     Email = customer.Email,
            //     Phone = customer.Phone,
            //     Zip = customer.Zip
            // };
        }
    }
}