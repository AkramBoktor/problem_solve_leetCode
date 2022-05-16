using System;
using System.Linq;

namespace Hamming_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.HammingWeight(00000000000000000000000000001011));
            Console.WriteLine(Program.HammingWeight(00000000000000000000000000001011));
           
        }

        public static int HammingWeight(uint n)
        {
            int count = 0;

            while (n!=0)
            {
                n =n& (n - 1);
                count++;
            }

            return count;
        }
    }
}
