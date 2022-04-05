using System;

namespace Ransom_Note
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.CanConstruct("aa", "ab"));
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if((ransomNote.Length>=1 && magazine.Length>=1)&&(ransomNote.Length < Math.Pow(10, 5) && magazine.Length < Math.Pow(10, 5)))
            {
                foreach (var ch in ransomNote)
                {
                    if (!magazine.Contains(ch))
                    {
                        return false;
                    }
                    else
                    {
                        magazine  = magazine.Remove(magazine.IndexOf(ch), 1);
                    }
                    
                }
                return true;

            }
            return false;

        }

        public static string ReversString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
