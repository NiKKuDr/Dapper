using System;

namespace Average_Value_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3
            Console.WriteLine("Please Enter 10 numbers(or press 0 to complete entering numbers): ");

            int[] numbers = new int[10];

            int inputCounter = 0;

            while (inputCounter < 10)
            {
                int enteredNumber = int.Parse(Console.ReadLine());
                numbers[inputCounter] = enteredNumber;
                inputCounter++;

                if (enteredNumber == 0)
                {
                    break;
                }
            }

            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                if (num > 0 && num % 3 == 0)
                {
                    sum += num;
                    count++;

                }
            }

            double average = (double)sum / count;
            Console.WriteLine($"Arithmetic mean is: {average}");



























            // 2
            /*Console.WriteLine("Plese enter 10 whole positive numbers\n(you can stop entering numbers just pressing 0)");
          
            int[] numbers = new int[10];
            int inputCounter = 0;

            while (inputCounter < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCounter] = number;

                inputCounter++;

                if (number == 0)
                {
                    break;
                }
            }

            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                if (num > 0 && num % 3 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine($"Arithmetic mean of entered numbers is: {average}");

            Console.ReadLine();
*/

            // 1
            /*Console.WriteLine("Enter no more than 10 positive numbers (you can stop entering by entering 0): ");
            
            int[] numbers = new int [10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                {
                    break;
                }
            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine($"Arithmetic mean of entered numbers is: {average}");*/

            /*Console.ReadLine();*/
        }
    }
}
