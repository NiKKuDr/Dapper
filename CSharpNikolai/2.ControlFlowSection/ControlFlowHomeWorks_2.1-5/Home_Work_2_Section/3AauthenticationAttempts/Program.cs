using System;

namespace _3AauthenticationAttempts
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty";
            string login = "johnsilver";

            int tries = 1;

            while (tries <= 3)
            {
                Console.WriteLine("Enter Login: ");
                string userLogin = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                string userPassword = Console.ReadLine();

                Console.Clear();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Enter the system");
                    break;
                }
                tries++;
            }
            if (tries == 4)
            {
                Console.WriteLine("You exceeded the number of available attempts.");
            }
            Console.ReadLine();
        }
    }
}
