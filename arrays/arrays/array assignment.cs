using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Monitor", "Keyboard", "Mouse", "CPU" };

            Console.WriteLine("Select one for the array (0-3):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("That does not exist in the array.");
            }
            int[] intArray = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Select one for the array (0-4):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("That does not exist in the array.");
            }
            List<string> stringList = new List<string>()
            {
                "Blue",
                "Purple",
                "Green",
                "Yellow"
            };

            Console.WriteLine("Select one for the list (0-3):");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("You selected: " + stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("That does not exist in the list.");
            }
            Console.ReadLine();

        }
    }
}