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

        public static void DisplayMenuToCreateCustomer(Repository repository)
        {
            Console.WriteLine("First name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("10 digit phone number, digits only (can be null): ");
            var phone = Console.ReadLine();
            Console.WriteLine("Email (can be null): ");
            var email = Console.ReadLine();
            Console.WriteLine("Zip code (can be null): ");
            var zip = Console.ReadLine();

            Console.WriteLine($"\n\n{firstName} {lastName}\t{phone}\t{email}\t{zip}");
            Console.WriteLine("\n\nDo you wish to save the above customer information? (Y or N)\n");
            var input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                try
                {
                    Customer customer = 
                        new Customer() {FirstName = firstName, LastName = lastName, Phone = phone, Email = email, Zip = zip, CustomerId = 0};
                    if (repository.CreateCustomer(customer))
                    {
                        Console.WriteLine("Customer added.");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Customer not created.");
                    Console.WriteLine(e.Message);
                }
                
            }
            if (input == "n")
            {

            }
            
  
        }

        
    }
}