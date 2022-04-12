using System;
using System.Collections.Generic;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsPalindrome(123321));
        }

        public static bool IsPalindrome(int x)
        {
            //if (x.ToString().Length == 1) return true;
            //string reverseNumber = string.Empty;
            //int lengthOfInteger = x.ToString().Length-1;

            //while (lengthOfInteger >= 0)
            //{
            //    reverseNumber += x.ToString()[lengthOfInteger];
            //    lengthOfInteger--;
            //}

            //return reverseNumber == x.ToString() ? true : false;
       
           
                if (x < 0) return false;
                String s = x.ToString();
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - 1 - i]) return false;
                }
                return true;
            }
        }

    }
