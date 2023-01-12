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
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int longestLengthOfSubsstring = 0;
            int count = 0;
            char ch = ' ';

            List<char> charItems = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!charItems.Contains(s[i]))
                {
                    charItems.Add(s[i]);
                    count++;
                }
                else
                {
                    if (charItems.Count > count)
                        count = charItems.Count;

                    charItems.Clear();
                    charItems.Add(s[i]);

              
                    longestLengthOfSubsstring =longestLengthOfSubsstring > count ? longestLengthOfSubsstring: count;

                    count = 1;
                }
            }

            return longestLengthOfSubsstring > count ? longestLengthOfSubsstring : count;
        }
    }
}
