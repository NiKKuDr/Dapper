using System;

namespace HomeWork_1_Section
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("What's your name?");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}!");
            Console.ReadKey();

            Console.Clear();

            // 2

            Console.WriteLine("Enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your numbers are: {firstNumber} and {secondNumber}");

            
            int thirdValue = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdValue;
            
            Console.WriteLine($"After changing places: {firstNumber} and {secondNumber}");


            // 3 

            Console.WriteLine("Enter an integer:");
            int intLength = Convert.ToInt32(Console.ReadLine());
            // int intLength = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of digits in number: {intLength.ToString().Length}");
            
            


      


            Console.ReadLine();
        }
    }
}
