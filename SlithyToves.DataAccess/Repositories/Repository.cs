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
                new Library.Models.CustomerModel(result.FirstName, result.LastName, result.Phone, result.Email, result.Zip, result.CustomerId);
            Console.WriteLine($"\n\nCustomer ID: {customer.CustomerId}\nName: {customer.FirstName} {customer.LastName}\nPhone: {customer.Phone}\nEmail: {customer.Email}\nZip: {customer.Zip}");
            return customer;
        }

        public List<Library.Models.CustomerModel> GetCustomerByName(string partOfName)
        {
            List<Library.Models.CustomerModel> list = new List<Library.Models.CustomerModel>();
            var results = _dbContext.Customers.Where(x => x.FirstName.ToLower().Contains(partOfName) || x.LastName.ToLower().Contains(partOfName));


            foreach (var result in results)
            {
                list.Add(new Library.Models.CustomerModel(result.FirstName, result.LastName, result.Phone, result.Email, result.Zip, result.CustomerId));
                Console.WriteLine($"{result.CustomerId}\t{result.FirstName} {result.LastName}\t{result.Phone}\t{result.Email}\t{result.Zip}");
            }
            return list;
        }

        public bool CreateCustomer(Customer customer)
        {
            Customer customerToCreate = new Customer() 
                { FirstName = customer.FirstName, LastName = customer.LastName, Phone = customer.Phone, 
                    Email = customer.Email, Zip = customer.Zip };
            
            _dbContext.Add(customerToCreate);
            _dbContext.SaveChanges();

            return true;
        }
    }
}