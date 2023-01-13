/*
 Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
*/
using System;
using System.Collections.Generic;

namespace Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(Program.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(Program.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(Program.LengthOfLongestSubstring(" "));
            Console.WriteLine(Program.LengthOfLongestSubstring("aab"));
            Console.WriteLine(Program.LengthOfLongestSubstring("dvdf"));
        }

        #region first
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int longestLengthOfSubString = 0;
            int count = 0;
            List<char> charItems = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {

                for (int j = i; j < s.Length; j++)
                {
                    if (!charItems.Contains(s[j]))
                    {
                        charItems.Add(s[j]);
                        count++;
                    }
                    else
                    {
                        if (charItems.Count > count)
                            count = charItems.Count;

                        charItems.Clear();
                        break;
                    }
                }
                longestLengthOfSubString = longestLengthOfSubString > count ? longestLengthOfSubString : count;

                count = 0;
            }

            return longestLengthOfSubString > count ? longestLengthOfSubString : count;
        }
        #endregion 
    }
}
