using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "fall";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);

            Console.ReadLine();
            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Wooden Wedding";
                    break;
                case 10:
                    name = "Tin Wedding";
                    break;
                case 15:
                    name = "Crystal Wedding";
                    break;
                case 20:
                    name = "Porcelain Wedding";
                    break;
                case 25:
                    name = "Silver Wedding";
                    break;
                case 30:
                    name = "Pearl Wedding";
                    break;
                default:
                    name = "Unknown Wedding";
                    break;
            }
            Console.WriteLine(name);
        }
    }
}
