using System;
using System.Collections.Generic;

namespace ArrayAndLists
{
    class Program
    {
        enum Days
        {
            one,
            two,
            three,
            four,
            five
        }
        static void Main(string[] args)
        {
            int[] array = new int[5]; // { 0, 1, 2};
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            Console.WriteLine($"{0}, {1}, {2}, {3}, {4}", array);

            List<int> list = new List<int>(); /*{ 0, 1, 2, 3, 4,}*/         
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine($"{0}, {1}, {2}, {3}, {4}", array);

            Console.WriteLine($"First number: {Days.one}");

            Console.ReadLine();
        }
    }
}
