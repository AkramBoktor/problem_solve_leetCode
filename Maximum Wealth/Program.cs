using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_Wealth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.MaximumWealth(new int[][] { new int[] { 1, 2, 3 },new int[] { 3, 2, 1 } }));
        }

        public static int MaximumWealth(int[][] accounts)
        {
            List<int> maxValueHealth = new List<int>();

            for (int row = 0; row < accounts.Length; row++)
            {
                int maxSumHealth = 0;
                for (int col = 0; col < accounts[row].Length; col++)
                {
                    maxSumHealth += accounts[row][col];
                }

                maxValueHealth.Add(maxSumHealth);
            }

            return maxValueHealth.OrderByDescending(x => x).FirstOrDefault();
        }
    }
}
