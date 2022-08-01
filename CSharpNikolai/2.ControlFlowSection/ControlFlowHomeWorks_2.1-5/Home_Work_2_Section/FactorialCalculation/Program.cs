using System;

namespace FactorialCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number( >= 0) whose factorial you want to calculate: ");
            int calculatedNumber = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= calculatedNumber; i++)
            {
                factorial *= i;
            }

            Console.Write(factorial);

            Console.ReadLine();

        }
    }
}
