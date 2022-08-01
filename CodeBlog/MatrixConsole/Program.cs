using System;
using System.Threading;

namespace MatrixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int delayBetweenStrings = 3000;
            int delayBetweenLetters = 70;
            string[] strings = { "Wake up, Neo...", "The Matrix has you...", "Follow the white rabbit...", "Knock, knock, Neo." };

            PrintSrtingsWithDelay(strings, delayBetweenStrings, delayBetweenLetters);

            Console.ReadKey();
        }

        private static void PrintSrtingsWithDelay(string[] strings, int delayBetweenStrings, int delayBetweenLetters)
        {
            foreach (var e in strings)
            {
                Console.Clear();
                PrintLettersWithDelay(e, delayBetweenLetters);
                Thread.Sleep(delayBetweenStrings);
            }
        }

        private static void PrintLettersWithDelay(string text, int delay)
        {
            foreach (var letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(delay);
            }
        }
    }
}
