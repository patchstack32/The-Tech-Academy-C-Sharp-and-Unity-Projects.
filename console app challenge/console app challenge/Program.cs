using System;

namespace consoleappchallenge
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How many hours per week?");
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How many hours per week?");
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());

            decimal salary1 = rate1 * hours1 * 52;
            decimal salary2 = rate2 * hours2 * 52;

            Console.WriteLine("Annual salary for Person 1");
            Console.WriteLine("salary1");

            Console.WriteLine("Annual salary for Person 2");
            Console.WriteLine("salary2");

            Console.WriteLine("Does Person 1 make more than Pesrson 2?");
            Console.WriteLine(salary1 > salary2);

            Console.ReadLine();
        }
    }
}