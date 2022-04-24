using System;
using System.Numerics;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(",", Program.PlusOne(new int[] { 1, 2, 3 })));
            //Console.WriteLine(string.Join(",", Program.PlusOne(new int[] { 4, 3, 2, 1 })));
            //Console.WriteLine(string.Join(",", Program.PlusOne(new int[] { })));
            //Console.WriteLine(string.Join(",", Program.PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })));


            //Console.WriteLine(string.Join(",", Program.PlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 })));
            Console.WriteLine(string.Join(",", Program.PlusOne(new int[] { 6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 3 })));
        }

        public static int[] PlusOne(int[] digits)
        {
            string numberAsstring= string.Empty;

            foreach (int digit in digits)
            {
                numberAsstring += digit;
            }

             numberAsstring = (BigInteger.Parse(numberAsstring) + 1).ToString();

            int[] arrayOfInteger = new int[numberAsstring.ToString().Length];

            for (int i = 0; i < numberAsstring.Length; i++)
            {
                arrayOfInteger[i] = int.Parse(numberAsstring.Substring(i,1));
            }

            return arrayOfInteger;
        }
    }
}
