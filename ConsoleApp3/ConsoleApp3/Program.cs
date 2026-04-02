using System;

namespace BooleanLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop");
            bool keepRunning = true;
            int counter = 0;

            while (keepRunning)
            {
                Console.WriteLine("While loop iteration: " + counter);
                counter++;

                if (counter >= 5)
                {
                    keepRunning = false;
                }
            }

            Console.WriteLine("Do While Loop");
            bool runDoWhile = true;
            int doCounter = 0;

            do
            {
                Console.WriteLine("Do While loop iteration: " + doCounter);
                doCounter++;

                if (doCounter >= 3)
                {
                    runDoWhile = false;
                }
            } while (runDoWhile);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}