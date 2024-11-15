using System;

namespace Lane_Counter
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int currentLane = 1; // Start at lane 1
            Console.WriteLine("Press the spacebar."); //Holding also increases it, kinda cool
            Console.WriteLine("Press 'Esc' to exit.");

            while (true)
            {
                if (Console.KeyAvailable) //For the check
                {
                    var key = Console.ReadKey(intercept: true).Key; //To make sure spacebar

                    if (key == ConsoleKey.Spacebar) //For the spacebar specifically
                    {
                        Console.Clear();
                        Console.WriteLine("Current Lane: " + currentLane); 
                        currentLane++; //Increase lane
                    }
                    else if (key == ConsoleKey.Escape) //For an exit
                    {
                        break; //End
                    }
                }
            }
        }
    }
}
