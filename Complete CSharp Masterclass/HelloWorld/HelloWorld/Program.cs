using System;

namespace HelloWorld
{
    class Program
    {

        // Entry point of our program
        static void Main(string[] args)
        {
          /*  Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();*/
            Console.WriteLine("Hello Nikolai!");
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a key and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();

        }
    }
}
