using System;
using System.Collections.Generic;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Hello", "World", "C#", "Programming" };

            while (true)
            {
                Console.WriteLine("Enter text to add onto the words:");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    break;
                }

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] += " " + userInput;
                }

                Console.WriteLine("updated strings:");
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

                Console.WriteLine("display using <= loop:");
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    Console.WriteLine(words[i]);
                }

                // string list
                List<string> items = new List<string>(words)
                {
                    "mouse", "keyboard", "monitor", "headphones"
                };

                Console.WriteLine("Enter text to search within the list:");
                string search = Console.ReadLine().ToLower();

                bool found = false;

                // loops through the list to find a match for the search term
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].ToLower().Contains(search))
                    {
                        Console.WriteLine($"Found '{search}' in '{items[i]}'");
                        found = true;
                        break; // stops the loop after finding the first match
                    }
                }

                // If not found
                if (!found)
                {
                    Console.WriteLine("That's not in the list.");
                }

                List<string> newItems = new List<string>()
                {
                    "mouse", "keyboard", "monitor", "headphones", "headphones", "monitor"
                };

                Console.WriteLine("Enter text to search within the new list:");
                string search2 = Console.ReadLine().ToLower();

                bool found2 = false;

                for (int i = 0; i < newItems.Count; i++)
                {
                    if (newItems[i].ToLower() == search2)
                    {
                        Console.WriteLine("Match found at index: " + i);
                        found2 = true;
                    }
                }

                if (!found2)
                {
                    Console.WriteLine("That's not in the new list.");
                }

                List<string> itemsCheck = new List<string>()
                {
                "water", "soda", "juice", "tea", "coffee", "water",
                };

                List<string> seenItems = new List<string>();

                foreach (string item in itemsCheck)
                {
                    if (seenItems.Contains(item))
                    {
                        Console.WriteLine(item + " has already appeared in the list.");
                    }
                    else
                    {
                        Console.WriteLine(item + " has NOT appeared yet.");
                        seenItems.Add(item);
                    }
                }
            }
        }
    }
}