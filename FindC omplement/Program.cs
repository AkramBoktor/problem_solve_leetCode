using System;

namespace FindComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.FindComplement(5));
        }


        public static int FindComplement(int num)
        {
            string binaryNumber = Convert.ToString(num, 2);
            string reverseBinaryNumber = string.Empty;
            foreach (var digit in binaryNumber)
            {
                reverseBinaryNumber += digit == '1' ? '0' : '1';
            }

            return (int)Convert.ToInt64(reverseBinaryNumber, 2);
        }
    }
}
/*
   return Convert.ToInt32(string.Join("", Convert.ToString(num, 2).Select(b => b == '0' ? '1' : '0')), 2);
 */
/*
 Input: num = 5
Output: 2
Explanation: The binary representation of 5 is 101 
(no leading zero bits), and its complement is 010. So you need to output 2.
 
 */ 