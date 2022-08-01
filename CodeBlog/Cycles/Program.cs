using System;
using System.Collections.Generic;

namespace Cycles
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			int Counting = 1;
			int Sum = 0;
			int Difference = 0;
			int Diff = 0;
			int Multiply = 1;
			int Mult = 0;

			Console.WriteLine("Enter 15 integers");

			for (int i = 0; i < 15;)
			{
				Console.Write($"{Counting} number: ");
				string Enter = Console.ReadLine();
				Console.Clear();

				if (int.TryParse(Enter, out int Number))
				{
					list.Add(Number);
					Counting++;
					i++;
				}
				else
				{
					Console.WriteLine("You entered a non-integer number, please try again.");
				}
			}


			Console.WriteLine("You entered the following numbers: ");
			foreach (int item in list)
			{
				Console.Write($"{item}  ");
			}


			Console.WriteLine();
			for (int i = 0; i < list.Count; i++)
			{
				Sum += list[i];
			}

			Console.WriteLine($"The sum of all numbers: {Sum}");


			Difference += list[0];

			while (Diff < list.Count)
			{
				Difference -= list[Diff];
				Diff++;
			}

			Console.WriteLine($"Difference of all numbers: {(Difference + list[0])}");


			do
			{
				Multiply *= list[Mult];
				Mult++;
			}
			while (Mult < list.Count);

			Console.WriteLine($"Multiplication of all numbers: {Multiply}");

			Console.ReadKey();
		}

	}
}
