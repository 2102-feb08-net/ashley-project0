using SlithyToves.DataAccess;
using System;
using System.Collections.Generic;

namespace SlithyToves.ConsoleApp
{
    public static class CustomerUI
    {
        public static void DisplayMenuToGetCustomerById(Repository repository)
        {
            Console.WriteLine("Please enter the ID of the customer: ");
            var id = Convert.ToInt32(Console.ReadLine());
            repository.GetCustomerById(id);
        }

        public static void DisplayMenuToGetCustomerByName(Repository repository)
        {
            Console.Write("Enter any part of customer name: ");
            var partOfName = Console.ReadLine().ToLower();
            repository.GetCustomerByName(partOfName);       
        }

        public static void DisplayMenuToGetAllCustomers(Repository repository)
        {

        }

        
    }
}