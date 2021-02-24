using SlithyToves.DataAccess;
using System;

namespace SlithyToves.ConsoleApp
{
    public static class CustomerUI
    {
        public static void DisplayMenuToGetCustomerById(Repository repository)
        {
            Console.WriteLine("Please enter the ID of the customer: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var orders = repository.GetCustomerById(id);
        }

        public static void DisplayMenuToGetCustomerByName(Repository repository)
        {
            Console.Write("Customer Last Name: ");
            var lastname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Customer First Name: ");
            var firstname = Console.ReadLine();
            Console.WriteLine();
            

        }

        
    }
}