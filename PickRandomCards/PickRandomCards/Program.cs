using System;

namespace PickRandomCards
{
    class Program
    {
              // void return type means is not required to have a return statement
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Number was NOT valid. Please enter a valid number.");
            }

            Console.ReadLine();
        }
    }
}
