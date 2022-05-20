using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_K_Distant_Indices
{
    class Program
    {
        // بجيب الرقم اللى هو ال key
        // الرقم اللي اصغر منه والرقم اللى اكبر منه وادخله جوه الليست
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(',', Program.FindKDistantIndices(new int[] { 3, 4, 9, 1, 3, 9, 5 }, 9, 1)));
            Console.WriteLine(string.Join(',', Program.FindKDistantIndices(new int[] { 2, 2, 2, 2, 2 }, 2,2)));
        }


        public static IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            HashSet<int> distinctElement = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == key)
                {
                    for (int j = i - k; j <= i + k; j++)
                    {
                        distinctElement.Add(j);
                    }

                }
                   
            }

            return distinctElement.Where(o=>o>=0 && o < nums.Length).OrderBy(o => o).ToList();
        }
    }
}
