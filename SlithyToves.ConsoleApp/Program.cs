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
                var input1 = Console.ReadLine();

                if (input1 == "a" || input1 == "b" || input1 == "c" || input1 == "d")
                {
                    if (input1 == "a") 
                    {
                        CustomerUI.DisplayMenuToGetCustomerById(repository);
                        PrintShortMenu();
                        var input2 = Console.ReadLine();
                        if (input2 == "m")
                        {
                            continue;
                        }
                        else if (input2 == "q")
                        {
                            break;
                        }
                    }
                    else if (input1 == "b")
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    continue;
                }              
            }
            Console.WriteLine("\n\nHave a nice day!\n");
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("\nSlithy Toves Bookish Interface\n");
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("a - To search for a customer by ID");  // add search by name
            Console.WriteLine("b - To create a new customer");   // add search by name
            Console.WriteLine("c - To place an order");
            Console.WriteLine("d - To view the order history of a customer");
            Console.WriteLine("e - To view the details of an order");
            Console.WriteLine("f - To view the order history of a location");
            Console.WriteLine("g - To quit\n");
            Console.WriteLine("Select an option a-g: ");
        }



        public static void PrintShortMenu()
        {
            Console.WriteLine("\nm - To return to the main menu");
            Console.WriteLine("q - To quit\n");
        }
    }
}

