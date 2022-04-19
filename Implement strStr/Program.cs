using System;

namespace Implement_strStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.StrStr("aaaaa", "bba"));
        }

        public static int StrStr(string haystack, string needle)
        {

            if (needle == string.Empty) return 0;

            if (haystack.Contains(needle)) return haystack.IndexOf(needle);
                    
              return -1;


        }
    }
}
