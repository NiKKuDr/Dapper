using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers2 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            foreach(int n in numbers2)
            {
                /*if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }*/
                if (n % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(n);
            }


            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine($"Number = {numbers2[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers2[i] == j)
                    {
                        break;
                    }
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                {
                    break;
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if(counter == 3)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
