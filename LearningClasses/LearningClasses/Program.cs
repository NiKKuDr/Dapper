using System;
using System.Collections.Generic;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            void fillList()
            {
                numberList.Add(1);
                numberList.Add(3);
                numberList.Add(5);
                numberList.Add(7);
            }

            Console.WriteLine(numberList);
        }
    }
}
