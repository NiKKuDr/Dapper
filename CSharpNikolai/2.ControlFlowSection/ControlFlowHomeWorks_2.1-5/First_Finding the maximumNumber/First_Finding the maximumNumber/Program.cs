using System;

namespace First_Finding_the_maximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            // 1 solution

            /*int largestNumber;

            if ( firstNumber > secondNumber)
            {
                largestNumber = firstNumber;
            }
            else
            {
                largestNumber = secondNumber;
            }

            Console.WriteLine($"Largest number: {largestNumber}");*/

            // 2 solution

            /*int largestNumber = firstNumber;
            if (secondNumber > firstNumber)
                largestNumber = secondNumber;

            Console.WriteLine($"Largest number: {largestNumber}");*/

            // 3 solution 

            int largestNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"Largest number: {largestNumber}");

            Console.ReadLine();
        }
    }
}
