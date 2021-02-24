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
            var customer = _dbContext.Customers.Find(id);
            return new Library.Models.CustomerModel
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone,
                Zip = customer.Zip
            };
        }
    }
}