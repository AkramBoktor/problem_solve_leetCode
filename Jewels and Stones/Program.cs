using System;
using System.Linq;

namespace Jewels_and_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.NumJewelsInStones("Aa", "AaZZA"));
            Console.WriteLine(Program.NumJewelsInStones("aA", "aAAbbbb"));
            Console.WriteLine(Program.NumJewelsInStones("z", "ZZ"));
        }


        public static int NumJewelsInStones(string jewels, string stones)
        {
            if (string.IsNullOrEmpty(jewels)) return 0;
            int countOfJewels = 0;
            for (int i = 0; i < jewels.Length; i++)
            {
               
                countOfJewels += stones.Where(c => c == jewels[i]).Count();
            }

            return countOfJewels;
        }
    }
}
