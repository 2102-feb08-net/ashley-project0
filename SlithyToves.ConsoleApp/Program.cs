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
            using var disposables = new Disposables();
            var context = disposables.getConnectionContext();
            Repository repository = new Repository(context);

            ConsoleUI(repository);
        }

        public static void ConsoleUI(Repository repository)
        {
            
            while (true)
            {
                PrintMainMenu();
                var input = Console.ReadLine();

                if (input == "a" || input == "b" || input == "c" || input == "d")
                {
                    if (input == "a") 
                    {
                        CustomerUI.DisplayCustomerMenu(repository);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    continue;
                }
            }
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("\nSlithy Toves Bookish Interface\n");
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("a - To search for customers by ID");  // add search by name
            Console.WriteLine("b - To add a customer");
            Console.WriteLine("c - To place an order");
            Console.WriteLine("d - To view the order history of a customer");
            Console.WriteLine("e - To view the details of an order");
            Console.WriteLine("f - To view the order history of a location");
            Console.WriteLine("g - To quit\n");
            Console.WriteLine("Select an option a-g: ");
        }



        public static void PrintShortMenu()
        {
            Console.WriteLine("\nTo return to the main menu, please enter \"1\"");
            Console.WriteLine("To quit, enter \"2\"");
        }

        

    }
}

