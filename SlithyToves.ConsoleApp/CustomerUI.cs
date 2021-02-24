using SlithyToves.DataAccess;
using System;

namespace SlithyToves.ConsoleApp
{
    public static class CustomerUI
    {
        public static void DisplayCustomerMenu(Repository repository)
        {
            Console.WriteLine("Please enter the ID of the customer: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var orders = repository.GetCustomerById(id);
        }
    }
}