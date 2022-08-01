using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Height:");
            double userHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Weight:");
            double userWeight = double.Parse(Console.ReadLine());

            double bmiUser = userWeight / (userHeight * userHeight);

            bool isTooLow = bmiUser <= 18.5;
            bool isNormal = bmiUser > 18.5 && bmiUser < 25;
            bool isAboveNormal = bmiUser >= 25 && bmiUser <= 30;
            bool isTooFat = bmiUser > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");
            }
            else
            {
                Console.WriteLine("You're in a good shape.");
            }
            if (!isFat)
            {
                Console.WriteLine("You're definetely not fat!");
            }
            if (isTooLow)
            {
                Console.WriteLine("Not enough weight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're OK");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You nedd to lose some weight.");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }

            // ternary operation
            string description = userAge > 18 ? "You can drink alcohol" : "You should get bit older";


            // the same in if-else construct
            /*   if (userAge > 18)
               {
                   description = "You can drink alcohol";
               }
               else
               {
                   description = "You should get a bit older";
               }*/
            Console.WriteLine(description);
           
            Console.ReadLine();
        }
    }
}
