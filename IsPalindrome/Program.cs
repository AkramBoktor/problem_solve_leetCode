using System;
using System.Text.RegularExpressions;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsPalindrome("A man, a plan, a canal: Panama"));
        }


        public static bool IsPalindrome(string s)
        {
            if (s == null) return true;

            Regex regex = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);

            string nonAlphanumbericString =  regex.Replace(s, "");

           string reversenonAlphanumbericString =    ReversString(nonAlphanumbericString);

            return reversenonAlphanumbericString.ToLower() == nonAlphanumbericString.ToLower() ? true : false;


        }

        public static string ReversString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}