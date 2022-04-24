using System;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.LengthOfLastWord("Hello world"));
            Console.WriteLine(Program.LengthOfLastWord(" fly me   to   the moon  "));
            Console.WriteLine(Program.LengthOfLastWord("luffy is still joyboy"));
            Console.WriteLine(Program.LengthOfLastWord("a"));
            Console.WriteLine(Program.LengthOfLastWord(" a"));
            Console.WriteLine(Program.LengthOfLastWord(" "));
            Console.WriteLine(Program.LengthOfLastWord("    day"));

        }

        public static int LengthOfLastWord(string s)
        {
            s = s.Trim();
            if (s == string.Empty || s.Length == 0 || s == null) return 0;
            int length = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                if(s[i]!=' ')
                {
                    length++;
                }
                else
                {
                    break;
                }
            }

            return length;
            //s = s.Trim();
            //if (s == string.Empty || s.Length == 0 || s == null) return 0;
            //string reverseString = string.Empty;
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    reverseString += s[i];
            //}

            //return reverseString.Contains(" ") ? reverseString.Trim().IndexOf(" ", 0) : reverseString.Length;
        }
    }
}
