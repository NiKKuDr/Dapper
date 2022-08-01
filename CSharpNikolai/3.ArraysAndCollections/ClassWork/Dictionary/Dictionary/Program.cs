using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Johny");
            people.Add(3, "Johan");

            people = new Dictionary<int, string>()
            {
                { 1, "John" },
                { 2, "Johny" },
                { 3, "Johan" }
            };

            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over values");
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Iterating over key-value pairs");
            foreach (KeyValuePair<int, string> pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Count={people.Count}");

            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");

            Console.WriteLine($"Contains key: {containsKey}. Contains value: {containsValue}");

            people.Remove(1);

            if(people.TryAdd(2, "Ellias"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add using key 2");
            }

            if( people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val={val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }

            people.Clear();

            Console.ReadLine();
        }

    }
}
