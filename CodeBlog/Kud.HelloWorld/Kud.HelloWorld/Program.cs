using System;
using MyLib;

namespace Kud.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new("Tom");
            tom.Print();
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
