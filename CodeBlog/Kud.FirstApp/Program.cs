using System;
using System.Threading;

namespace Kud.FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wake up Neo...");
            Console.Beep();
            Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("The matrix has you...");
            Console.Beep();
            Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("Follow the White Rabbit...");
            Console.Beep();
            Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("Knock, Knock, Neo.");
            Console.Beep();
            Thread.Sleep(2500);
          
            Console.ReadLine();


        }
    }
}
