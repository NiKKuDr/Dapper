using System;

namespace UserProfile
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

            Console.WriteLine();

            Console.WriteLine($"Your Profile:\n" +
                              $"Full Name: {userName} {userLastName}\n" +
                              $"Age: {userAge}\n" +
                              $"Weight: {userWeight}\n" +
                              $"Height: {userHeight}\n" +
                              $"Body Mass Index: {Math.Round(bmiUser, 2)}");
            Console.ReadLine();
        }
    }
}
