using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Приведение. */

            byte BYTEtoint = 1;
            int bytetoINT = BYTEtoint;                     /* Неявное приведение byte to int. */
            Console.WriteLine(bytetoINT);                  /* вывод результата неявного приведения. */
            int INTtobyte = 2;
            byte inttoBYTE = (byte)INTtobyte;              /* Явное приведение int to byte. */
            Console.WriteLine(inttoBYTE);
            Console.WriteLine();


            byte BYTEtochort = 3;
            short bytetoSHORT = BYTEtochort;               /* Неявное приведение byte to short. */
            Console.WriteLine(bytetoSHORT);
            short SHORTtobyte = 4;
            byte shorttoBYTE = (byte)SHORTtobyte;          /* Явное приведение short to byte. */
            Console.WriteLine(shorttoBYTE);
            Console.WriteLine();

            byte BYTEtofloat = 5;
            float bytetoFLOAT = BYTEtofloat;               /* Неявное приведение byte to float. */
            Console.WriteLine(bytetoFLOAT);
            float FLOATtobyte = 6;
            byte floattoBYTE = (byte)FLOATtobyte;          /* Явное приведение float to byte. */
            Console.WriteLine(floattoBYTE);
            Console.WriteLine();

            byte BYTEtolong = 7;
            long bytetoLONG = BYTEtolong;                  /* Неявное приведение byte tp long. */
            Console.WriteLine(bytetoLONG);
            long LONGtobyte = 8;
            byte longtoBYTE = (byte)LONGtobyte;            /* Явное приведение long to byte. */
            Console.WriteLine(longtoBYTE);
            Console.WriteLine();

            byte BYTEtodecimal = 9;
            decimal bytetoDECIMAL = BYTEtodecimal;         /* Неявное приведение byte to decimal. */
            Console.WriteLine(bytetoDECIMAL);
            decimal DECIMALtobyte = 10;
            byte decimaltoBYTE = (byte)DECIMALtobyte;      /* Явное приведение decimal to byte. */
            Console.WriteLine(decimaltoBYTE);
            Console.WriteLine();

            byte BYTEtodouble = 11;
            double bytetoDOUBLE = BYTEtodouble;            /* Неявное приведение byte to double. */
            Console.WriteLine(bytetoDOUBLE);
            double DOUBLEtobyte = 12;
            byte doubletoBYTE = (byte)DOUBLEtobyte;        /* Явное приведение double to byte. */
            Console.WriteLine(doubletoBYTE);
            Console.WriteLine();

            /* Преобразование. */
            byte BYTEtostring = 13;
            Console.WriteLine(BYTEtostring.ToString());    /* Явное преобразование byte to string. */
            bool BOOLEANtostring = true;
            Console.WriteLine(BOOLEANtostring.ToString()); /* Явное преобразование boolean to string. */
            int INTforplasstring = 15;
            Console.WriteLine();

            string str = "int " + INTforplasstring;        /* Неявное преобразование int to string. */
            Console.WriteLine(str);
            byte BYTEtochar = 1;
            char bytetoCHAR = Convert.ToChar(BYTEtochar);  /* Явное преобразование byte to char. */
            Console.WriteLine(bytetoCHAR);

            char s = '1';
            byte sss = (byte)s;                              /* Явное приведение char to byte. */
            Console.WriteLine(sss);
            Console.WriteLine();

            Console.WriteLine(Convert.ToByte(s));            /* Явное преобразование char to byte. */

            byte bytetostring = 16;
            string str1 = "byte " + bytetostring;            /* Неявное преобразование byte to string. */
            Console.WriteLine(str1);

            /* .GetHashCode. */
            byte byteghc = 255;
            Console.WriteLine(byteghc.GetHashCode());
            int intghc = 2147483647;
            Console.WriteLine(intghc.GetHashCode());

            bool booltrueghc = true;
            Console.WriteLine(booltrueghc.GetHashCode());
            bool boolfalseghc = false;
            Console.WriteLine(boolfalseghc.GetHashCode());

            /* Упорядочивание данных. (Сортировка). */
            int[] numbers = new int[] { 50, 40, 30, 20, 10 };
            Array.Sort(numbers);             /* Метод сортировки для массива(от меньшего к большему). */
            foreach (int n in numbers)       /* foreach -для каждого элемента
                                                (в данном случае - для каждого элемента Массива(array).а может быть ещё Список(List)).
                                              * int - возвращаемый тип, 
                                              * n - название переменной, 
                                              * numbers - имя созданного массива. */
                Console.WriteLine(n);
            Console.WriteLine();
            string a1 = "Have a nice day!";
            string a2 = "Such a wondeful day today!";
            Console.WriteLine(string.Compare(a1, a2)); /* Compare - сравнить. 
                                                           (сравнение НЕ по длине, а по ЗНАЧЕНИЕ символов)
                                                         * Если первая строка меньше, консоль вернет -1,
                                                         * Если первая строка больше, консоль вернет +1
                                                         * Если первая строка равна второй, вернет 0 */

        }
    }
}
