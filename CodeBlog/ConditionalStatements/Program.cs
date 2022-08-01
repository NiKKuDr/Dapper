using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int firstInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int thirdInput = Convert.ToInt32(Console.ReadLine());

            int biggestNumber = 0;
            if(firstInput >= secondInput && firstInput >= thirdInput)
            {
                biggestNumber = firstInput;
            } 
            else if(secondInput >=firstInput && secondInput >= thirdInput)
            {
                biggestNumber = secondInput;
            } 
            else if(thirdInput >= firstInput && thirdInput >= secondInput)
            {
                biggestNumber = thirdInput;
            }

            Console.WriteLine($"The largest number is {biggestNumber}");

            switch(biggestNumber%2==0)
            {
                case true:
                    Console.WriteLine("Number is Even");
                    break;
                default:
                    Console.WriteLine("Number is Odd");
                    break;
            }

            Console.WriteLine(biggestNumber < 100? "And the number is less than 100" : "And the number is over 100");


            Console.ReadLine();
        }
    }

}

