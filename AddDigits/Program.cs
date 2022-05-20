using System;
using System.Globalization;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.AddDigits(38));
        }

        public static int AddDigits( int num)
        {
            if (num.ToString().Length <= 1) return num;

            while (num.ToString().Length > 1)
            {
                int sum = 0;

                for (int i = 0; i <= num.ToString().Length-1; i++)
                {
                    sum += CharUnicodeInfo.GetDecimalDigitValue(num.ToString()[i]);
                }

                num = sum;
            }

            return num;

        }
    }
}

//while (num > 9)
//{
//    num = GetDigits(num);
//}
//return num;
//    }
//    public int GetDigits(int num)
//{
//    int sum = 0;
//    while (num > 0)
//    {
//        sum += num % 10;
//        num /= 10;
//    }
//    return sum;
//}