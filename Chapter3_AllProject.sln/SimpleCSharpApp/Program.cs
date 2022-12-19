using System;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("***** Hello World! *****");
            Console.WriteLine();
            //ShowEnvironmentDetails();
            ParseFromStringWithTryParse();
            Console.ReadLine();
        }

        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Core Version: {0}", Environment.Version);
        }

        static void ParseFromStringWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            else
            {
                Console.WriteLine("Default value of b: {0}", b);
            }

            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double and the variables was assigned" +
                    "the default {1}", value, d);
            }
            Console.WriteLine();
        }
    }
}
