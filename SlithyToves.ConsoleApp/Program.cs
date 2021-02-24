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

                if (input1 == "a" || input1 == "b" || input1 == "c" || input1 == "d" || input1 == "e")
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
                        CustomerUI.DisplayMenuToGetCustomerByName(repository);
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
                    else if (input1 == "c")
                    {
                        CustomerUI.DisplayMenuToCreateCustomer(repository);
                    }
                    else if (input1 == "d")
                    {

                    }
                    else if (input1 == "e")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }              
            }
            Console.WriteLine("\n\nHave a nice day!\n");
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("\nSlithy Toves Bookish Interface\n");
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("a - To search for a customer by ID");  
            Console.WriteLine("b - To search for a customer by name");   
            Console.WriteLine("c - To create a new customer");
            Console.WriteLine("d - To search for an order");
            Console.WriteLine("e - To quit");
            Console.WriteLine("Select an option a-e: ");
        }



        public static void PrintShortMenu()
        {
            Console.WriteLine("\nm - To return to the main menu");
            Console.WriteLine("q - To quit\n");
        }
    }
}

