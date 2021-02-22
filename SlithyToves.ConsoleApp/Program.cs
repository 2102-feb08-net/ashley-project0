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
        // static DbContextOptions<SlithyTovesContext> s_dbContextOptions;

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
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Input is 1");
                    break;
                }
            }
        }

        public static void PrintMainMenu() 
        {
            Console.WriteLine("\nSlithy Toves Bookish Interface\n");
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("To view a list of current customers, please enter \"1\"");
            Console.WriteLine("To add a customer, please enter \"2\"");
            Console.WriteLine("To place an order, please enter \"3\"");
            Console.WriteLine("To view the order history of a customer, please enter \"4\"");
            Console.WriteLine("To view the details of an order, please enter \"5\"");
            Console.WriteLine("To view the order history of a location, please enter \"6\"");
            Console.WriteLine("To quit, enter \"7\"");
        }

        public static void PrintShortMenu() 
        {
            Console.WriteLine("To return to the main menu, please enter \"1\"");
            Console.WriteLine("To quit, enter \"2\"");
        }
    }
}
