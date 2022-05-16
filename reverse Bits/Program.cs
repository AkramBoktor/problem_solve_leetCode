using System;

namespace reverse_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.reverseBits(101011100));
        }

        public static uint reverseBits(uint n)
        {
            Char[] CharToArray = n.ToString().ToCharArray();
            string reverseBitString = string.Empty;


            for (int i = CharToArray.Length-1; i >=0; i--)
            {
                reverseBitString += CharToArray[i];
            }

            return Convert.ToUInt32(reverseBitString,2);
        }
    }
}
