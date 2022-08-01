using System;

namespace Casting_and_type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteToInt = 1;
            int bytetoINT = byteToInt;                     /* Неявное приведение byte to int. */
            Console.WriteLine(byteToInt);                  /* вывод результата неявного приведения. */
            
            int intToByte = 2;
            byte inttoBYTE = (byte)intToByte;              /* Явное приведение int to byte. */
            Console.WriteLine(inttoBYTE + "\n");


            byte byteToShort = 3;
            short bytetoSHORT = byteToShort;               /* Неявное приведение byte to short. */
            Console.WriteLine(bytetoSHORT);
            
            short shortToByte = 4;
            byte shorttoBYTE = (byte)shortToByte;          /* Явное приведение short to byte. */
            Console.WriteLine(shorttoBYTE + "\n");

            byte byteToFloat = 5;
            float bytetoFLOAT = byteToFloat;               /* Неявное приведение byte to float. */
            Console.WriteLine(bytetoFLOAT);
            
            float floatToByte = 6;
            byte floattoBYTE = (byte)floatToByte;          /* Явное приведение float to byte. */
            Console.WriteLine(floattoBYTE + "\n");

            byte byteToLong = 7;
            long bytetoLONG = byteToLong;                  /* Неявное приведение byte tp long. */
            Console.WriteLine(bytetoLONG);
            
            long longToByte = 8;
            byte longtoBYTE = (byte)longToByte;            /* Явное приведение long to byte. */
            Console.WriteLine(longtoBYTE + "\n");

            byte byteToDecimal = 9;
            decimal bytetoDECIMAL = byteToDecimal;         /* Неявное приведение byte to decimal. */
            Console.WriteLine(bytetoDECIMAL);
            
            decimal decimalToByte = 10;
            byte decimaltoBYTE = (byte)decimalToByte;      /* Явное приведение decimal to byte. */
            Console.WriteLine(decimaltoBYTE + "\n");

            byte byteToDouble = 11;
            double bytetoDOUBLE = byteToDouble;            /* Неявное приведение byte to double. */
            Console.WriteLine(bytetoDOUBLE);
            
            double doubleToByte = 12;
            byte doubletoBYTE = (byte)doubleToByte;        /* Явное приведение double to byte. */
            Console.WriteLine(doubletoBYTE + "\n");

            /* Преобразование. */
            byte byteToString = 13;
            Console.WriteLine(byteToString.ToString() + "\n");    /* Явное преобразование byte to string. */
            
            bool BOOLEANtostring = true;
            Console.WriteLine(BOOLEANtostring.ToString() + "\n"); /* Явное преобразование boolean to string. */
            
            int intPlusString = 15;
            string str = "int " + intPlusString;        /* Неявное преобразование int to string. */
            Console.WriteLine(str + "\n");
            
            byte byteToChar = 1;
            char bytetoCHAR = Convert.ToChar(byteToChar);  /* Явное преобразование byte to char. */
            Console.WriteLine(bytetoCHAR + "\n");

            char symbol = '1';
            byte byteSymbol = (byte)symbol;                              /* Явное приведение char to byte. */
            Console.WriteLine(byteSymbol + "\n");

            Console.WriteLine(Convert.ToByte(symbol) + "\n");            /* Явное преобразование char to byte. */

            byte ByteToString = 16;
            string str1 = "byte " + ByteToString;                 /* Неявное преобразование byte to string. */
            Console.WriteLine(str1 + "\n");

            /* .GetHashCode. */
            byte byteGhc = 255;
            Console.WriteLine(byteGhc.GetHashCode() + "\n");
            
            int intGhc = 2147483647;
            Console.WriteLine(intGhc.GetHashCode() + "\n");

            bool boolTrueGhc = true;
            Console.WriteLine(boolTrueGhc.GetHashCode() + "\n");
            
            bool boolFalseGhc = false;
            Console.WriteLine(boolFalseGhc.GetHashCode() + "\n");

            /* Упорядочивание данных. (Сортировка). */
            int[] numbers = new int[] { 50, 40, 30, 20, 10 };
            Array.Sort(numbers);             /* Метод сортировки для массива(от меньшего к большему). */
            foreach (int n in numbers)       /* foreach -для каждого элемента
                                                (в данном случае - для каждого элемента Массива(array).а может быть ещё Список(List)).
                                              * int - возвращаемый тип, 
                                              * n - название переменной, 
                                              * numbers - имя созданного массива. */
            Console.Write(n);

            string firstGreeting = "Have a nice day!";
            string secondGreeting = "Such a wondeful day today!";
            Console.WriteLine(string.Compare(firstGreeting, secondGreeting));  /* Compare - сравнить. 
                                                           (сравнение НЕ по длине, а по ЗНАЧЕНИЕ символов)
                                                         * Если первая строка меньше, консоль вернет -1,
                                                         * Если первая строка больше, консоль вернет +1
                                                         * Если первая строка равна второй, вернет 0 */
        }
    }
}
