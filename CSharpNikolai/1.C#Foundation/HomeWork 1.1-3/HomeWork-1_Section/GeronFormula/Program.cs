using System;

namespace GeronFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers - the sides of the triangle:");
            Console.WriteLine("First Side:");
            double firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Second Side:");
            double secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Third Side:");
            double thirdSide = double.Parse(Console.ReadLine());

            double P = (firstSide + secondSide + thirdSide) / 2;
            double S = Math.Sqrt(P * (P - firstSide) * (P - secondSide) * (P - thirdSide));
  
            Console.WriteLine($"Square of the triangle is equals: {Math.Round(S, 2)}");

            Console.ReadLine();
        }
    }
}
