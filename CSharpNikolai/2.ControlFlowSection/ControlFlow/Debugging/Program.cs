using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers - the sides of the triangle:");
            Console.WriteLine("First Side:");
            double firstSide = GetDouble();

            Console.WriteLine("Second Side:");
            double secondSide = GetDouble();

            Console.WriteLine("Third Side:");
            double thirdSide = GetDouble();

            double P = (firstSide + secondSide + thirdSide) / 2;
            double S = Math.Sqrt(P * (P - firstSide) * (P - secondSide) * (P - thirdSide));

            Console.WriteLine($"Square of the triangle is equals: {Math.Round(S, 2)}");

            Console.ReadLine();
        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
     
    }
}
