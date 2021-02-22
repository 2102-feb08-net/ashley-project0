using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SlithyToves.DataAccess;
using Microsoft.Extensions.Logging;

namespace SlithyToves.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = File.ReadAllText("C:/revature/st-conn.txt");
            var options = new DbContextOptionsBuilder<SlithyTovesContext>()
                .UseSqlServer(connectionString)
                .LogTo(s => Debug.WriteLine(s), minimumLevel: LogLevel.Information)
                .LogTo(s => Debug.WriteLine(s), minimumLevel: LogLevel.Debug)
                .Options;
            var context = new SlithyTovesContext(options);

            while (true) 
            {
                PrintMainMenu();
                if (GetMenuSelection == 1)
                {
                    Console.WriteLine("Enter a customer ID: ");
                    var id = Convert.ToInt32(Console.ReadLine());

                }
            }
        }

        public static void PrintMainMenu() 
        {
            Console.WriteLine("\nSlithy Toves Bookish Interface\n");
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("1 - To view a list of current customers");
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
            Console.WriteLine("To return to the main menu, please enter \"1\"");
            Console.WriteLine("To quit, enter \"2\"");
        }

        public static int GetMenuSelection() => Convert.ToInt32(Console.ReadLine());
        
    }
}
