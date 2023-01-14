/*
Given a string s, return the longest 
palindromic
 
substring
 in s.

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
 
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace _Medium_Longest_Palindromic_Substring
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.LongestPalindrome("babad"));
            Console.WriteLine(Program.LongestPalindrome("cbbd"));
            Console.WriteLine(Program.LongestPalindrome("ac"));
            Console.WriteLine(Program.LongestPalindrome("a"));
            Console.WriteLine(Program.LongestPalindrome("bacabab"));
            Console.WriteLine(Program.LongestPalindrome("ccc"));
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            var reverseString = s.ToCharArray();
            Array.Reverse(reverseString);
            if (s == new string(reverseString))
                return s;

            int longestLengthOfSubString = 0;
            List<string> PlaindromList = new List<string>();
            var stringAsCharacters = s.ToCharArray();
            string plaindrom = string.Empty;
            for (int i = 0; i < stringAsCharacters.Length; i++)
            {
                plaindrom += s[i];

                for (int j = i+1; j < s.Length; j++)
                {
                    if (stringAsCharacters[i] != stringAsCharacters[j])
                    {
                        plaindrom += s[j];
                    }
                    else
                    {
                        plaindrom += s[j];
                        var plaindromCharArray = plaindrom.ToCharArray();
                        Array.Reverse(plaindromCharArray);
                        if (plaindrom ==  new string (plaindromCharArray))
                        {
                            longestLengthOfSubString = longestLengthOfSubString > plaindrom.Length ? longestLengthOfSubString : plaindrom.Length;
                            PlaindromList.Add(plaindrom);
                        }
                    }
                }

                plaindrom = string.Empty;     
            }

            return PlaindromList.OrderByDescending(s=>s.Length).FirstOrDefault() !=null ? PlaindromList.OrderByDescending(s => s.Length).FirstOrDefault() : new string( s.ToCharArray(0,1));
        }
    }
}
