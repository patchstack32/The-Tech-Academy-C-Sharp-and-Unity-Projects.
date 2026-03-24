using System;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;

namespace myConsoleProject
{
    internal class Program
    {
        static void Main()
        {
            // The title
            Console.WriteLine("Tech Academy");
            Console.WriteLine("Daily report");

            // Varuious Questions
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the course you are currently on?");
            string course = Console.ReadLine();

            Console.WriteLine("What's the page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need any help? Please answer True or False");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            
            Console.WriteLine("Is there any sort of feedback you want to provide? Be specidic");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours have you studied tonight?");
            decimal hoursStuided = Convert.ToDecimal(Console.ReadLine());

            // End Message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");
        }
    }
}