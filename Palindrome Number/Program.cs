using System;
using System.Collections.Generic;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsPalindrome(-121));
        }

        public static bool IsPalindrome(int x)
        {
            if (x.ToString().Length == 1) return true;
            string reverseNumber = string.Empty;
            int lengthOfInteger = x.ToString().Length-1;

            while (lengthOfInteger >= 0)
            {
                reverseNumber += x.ToString()[lengthOfInteger];
                lengthOfInteger--;
            }

            return reverseNumber == x.ToString() ? true : false;
            
        }
    }
}
