using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using SlithyToves.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SlithyToves.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            // string connectionString = File.ReadAllText("C:/revature/st-conn.txt");
            // var options = new DbContextOptionsBuilder<SlithyTovesContext>()
            //     .UseSqlServer(connectionString)
            //     .LogTo(s => Debug.WriteLine(s), minimumLevel: LogLevel.Information)
            //     .LogTo(s => Debug.WriteLine(s), minimumLevel: LogLevel.Debug)
            //     .Options;
            using var disposables = new Disposables();
            var context = disposables.getConnectionContext();
            Repository repository = new Repository(context);
            // var customer = context.Customers.Find(1);
            // Console.WriteLine(customer.FirstName);

            ConsoleUI(repository);
        }

        public static void ConsoleUI(Repository repository)
        {
            using var disposables = new Disposables();
            var context = disposables.getConnectionContext();
            Repository repository1 = new Repository(context);
            var customer = context.Customers.Find(1);
            Console.WriteLine(customer.FirstName);

            // Console.WriteLine();
            // while (true)
            // {
                
            //     PrintMainMenu();
            //     if (GetMenuSelection().Equals(1))
            //     {
            //         Console.WriteLine(repository.GetCustomerById(GetMenuSelection()));
            //         PrintShortMenu();
            //         if (GetMenuSelection().Equals(1))
            //         {
            //             continue;
            //         }
            //         break;                    
            //     }
            //     if (GetMenuSelection().Equals(2))
            //     {
            //         //CreateCustomer();
            //         PrintShortMenu();
            //         if (GetMenuSelection().Equals(1))
            //         {
            //             continue;
            //         }
            //         else
            //         {
            //             break;
            //         }
            //     }
            //     if (GetMenuSelection().Equals(3))
            //     {
            //         //CreateOrder();
            //         PrintShortMenu();
            //         if (GetMenuSelection().Equals(1))
            //         {
            //             continue;
            //         }
            //         else
            //         {
            //             break;
            //         }
            //     }
            //     if (GetMenuSelection().Equals(4))
            //     {
            //         //GetOrdersByCustomer();
            //         PrintShortMenu();
            //         if (GetMenuSelection().Equals(1))
            //         {
            //             continue;
            //         }
            //         else
            //         {
            //             break;
            //         }
            //     }
            //     if (GetMenuSelection().Equals(5))
            //     {
            //         //GetOrderDetailsById();
            //         PrintShortMenu();
            //         if (GetMenuSelection().Equals(1))
            //         {
            //             continue;
            //         }
            //         else
            //         {
            //             break;
            //         }
            //     }
            //     if (GetMenuSelection().Equals(6))
            //     {
            //         //GetOrdersByLocation();
            //         PrintShortMenu();
            //         if (GetMenuSelection().Equals(1))
            //         {
            //             continue;
            //         }
            //         else
            //         {
            //             break;
            //         }
            //     }
            //     if (GetMenuSelection().Equals(7))
            //     {
            //         Console.Write("Have a nice day!");
            //         break;
            //     }
            // }
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("\nSlithy Toves Bookish Interface\n");
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("1 - To search for customers by ID");  // add search by name
            Console.WriteLine("2 - To add a customer");
            Console.WriteLine("3 - To place an order");
            Console.WriteLine("4 - To view the order history of a customer");
            Console.WriteLine("5 - To view the details of an order");
            Console.WriteLine("6 - To view the order history of a location");
            Console.WriteLine("7 - To quit\n");
            Console.WriteLine("Select an option 1-7: ");
        }

        public static void PrintShortMenu()
        {
            Console.WriteLine("\nTo return to the main menu, please enter \"1\"");
            Console.WriteLine("To quit, enter \"2\"");
        }

        public static int GetMenuSelection() => Convert.ToInt32(Console.ReadLine());

    }
}

