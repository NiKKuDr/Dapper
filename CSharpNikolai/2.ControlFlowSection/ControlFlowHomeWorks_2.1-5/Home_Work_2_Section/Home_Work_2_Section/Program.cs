using System;

namespace Home_Work_2_Section
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Fibonacci numbers to display: ");
            int numberFibbonacci = int.Parse(Console.ReadLine());

            int[] fibonacciArray = new int[numberFibbonacci];
            int firstValue = 0;
            int secondValue = 1;

            fibonacciArray[0] = firstValue;
            fibonacciArray[1] = secondValue;

            for (int i = 2; i < numberFibbonacci; i++)
            {
                int nextValue = firstValue + secondValue;
                fibonacciArray[i] = nextValue;

                firstValue = secondValue;
                secondValue = nextValue;
            }
            foreach (int fib in fibonacciArray)
            {
                Console.Write(fib + " ");
            }

            /* Console.Write("How many Fibonacci numbers do you want to display in the console? ");
             int number = int.Parse(Console.ReadLine());
             Console.Clear();

             int[] fibonacci = new int[number];

             int firstNumber = 0;
             int secondNumber = 1;

             fibonacci[0] = firstNumber;
             fibonacci[1] = secondNumber;

             for (int i = 2; i < number; i++)
             {
                 int nextNumber = firstNumber + secondNumber;
                 fibonacci[i] = nextNumber;

                 firstNumber = secondNumber;
                 secondNumber = nextNumber;
             }
             foreach (int current in fibonacci)
             {
                 Console.Write(current + " ");
             }

 */

            /*int prev = 1;
            int current = prev;
            int temp;
            Console.Write(prev + " " + current + " ");

            while (current <= number)
            {
                Console.Write($"{current} ");
                temp = current;
                current = prev + current;
                prev = temp;
            }*/

            Console.ReadLine();
            
        }
    }
}
