using System;
using System.ComponentModel.DataAnnotations;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please enter package width");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length");
            int length = Convert.ToInt32(Console.ReadLine());

            decimal quote = (width * height * length * weight) / 100m;

            Console.WriteLine("Your estimated total for shipping the package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thanks!");

            Console.ReadLine();
        }
    }
}