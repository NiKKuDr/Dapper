using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  int age = 30;

            while(age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Do/While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);*/

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }


            Console.WriteLine("Good!");


            Console.ReadLine();
        }
    }
}
