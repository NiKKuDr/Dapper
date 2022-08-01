using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void IntroToArrays()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 0, 2, 4, 5, 7 };

            int[] a4 = { 1, 3, 5, 7, 9 };
            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"First:{first}. Last:{last}.");
        }
        static void MathDemo()
        {
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
        }
        static void Casting()
        {
            // Single line comment
            /*
             * Multi-line comment
             * We can write here many words
             * 
             */
            uint x = uint.MaxValue;

            Console.WriteLine(x);

            x = x + 1;

            Console.WriteLine(x);

            x = x - 1;

            Console.WriteLine(x);

            byte b = 3; // 0000 0011
            int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i; // 3.0

            b = (byte)i; // Explicit cast( Явное привидение)
            i = (int)f;  // Explicit cast( Явное привидение)

            f = 3.1f;
            i = (int)f;

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine($"Parsed i = {i}");

            int x2 = 5;
            int result = x2 / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);


            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(f);
            Console.WriteLine(l);
            Console.ReadLine();
        }

        static void ConsoleBasics()
        {

            /*Console.WriteLine("Hi, please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);*/

            Console.WriteLine("Hi, please tell me your age.");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("New Style ");
            Console.Write("New Style\n");



            Console.ReadLine();
        }
        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}";
            //string str2 = "My name is " + name + " and I'm " + age;
            string str3 = "My name is \nJohn";
            string str4 = "My name is \tJohn";
            string str5 = $"My name is {Environment.NewLine}John";
            string str6 = "I'm Nik and I'm a \"good\" programmer";
            string str7 = "C:\\tmp\\test_file.txt";
            string str8 = @"C:\tmp\test_file.txt";

            double answer = 43.75874589789589;
            string result = string.Format("{0:f}", answer);
            string result2 = string.Format("{0:f1}", answer);

            double money = 25.9;
            result = string.Format(money.ToString("C2"));
            result2 = string.Format("{0:C2}", money);
            result = $"{money:C2}";
            string stri1 = "abcde";
            string stri2 = "abcde";

            bool areEqual = stri1 == stri2;
            Console.WriteLine(areEqual);



            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(str7);
            Console.WriteLine(str8);
            Console.WriteLine(result);
            Console.WriteLine(result2);



            Console.ReadLine();
        }
        
    }
}
