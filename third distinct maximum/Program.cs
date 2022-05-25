using System;
using System.Linq;


namespace third_distinct_maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Program.ThirdMax(new int[] { 3, 2, 1 }));
            Console.WriteLine(Program.ThirdMax(new int[] { 1, 2 }));
            Console.WriteLine(Program.ThirdMax(new int[] { 1, 1 ,2 }));

            //Console.WriteLine(Program.ThirdMax(new int[] { 2, 2, 3, 1 }));
            //Console.WriteLine(Program.ThirdMax(new int[] { 3, 3, 4, 3, 4, 3, 0, 3, 3 }));
        }


        public static int ThirdMax(int[] nums)
        {
           var numDistinct =  nums.Distinct().OrderByDescending(num => num).ToArray();
            if (numDistinct.Length <= 2) return numDistinct.Max();
            return numDistinct.Select((s, i) => new { i, s })
         .Where(t => t.i == 2)
         .Select(t => t.s)
         .FirstOrDefault();
        }

    }
}
