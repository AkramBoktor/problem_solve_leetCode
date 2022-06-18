using System;

namespace Is_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsAnagram("anagram","nagaram"));
        }


        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var stringOne = s.ToLower().ToCharArray();
            var stringTwo = t.ToLower().ToCharArray();
            Array.Sort(stringOne);
            Array.Sort(stringTwo);
            for (int i = 0; i < s.Length; i++)
            {
                if (stringOne[i] != stringTwo[i]) return false;
            }

            return true;
        }
    }
}


/*
 Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
 */