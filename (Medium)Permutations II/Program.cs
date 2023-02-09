/*Given a collection of numbers, nums, 
    that might contain duplicates, return all possible unique permutations in any order.

 

Example 1:

Input: nums = [1, 1, 2]
Output:
[[1,1,2],
 [1,2,1],
 [2,1,1]]
Example 2:

Input: nums = [1, 2, 3]
Output:[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _Medium_Permutations_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", PermuteUnique(new int[] { 1, 2, 3 })));
        }
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {

            var result = new List<IList<int>>();
            if (nums.Length < 1)
                return result;
            var hs = new HashSet<int>();
            Permute(nums.ToList(), hs, result);
            return result;
        }

        private static void Permute(List<int> choiseList, HashSet<int> hs, List<IList<int>> premuteList)
        {
            if (choiseList.Count == hs.Count)  premuteList.Add(new List<int> (hs));

            for (int i = 0; i < choiseList.Count; i++)
            {
                if(!hs.Contains(choiseList[i]))
                {
                    hs.Add(choiseList[i]);
                    Permute(choiseList, hs, premuteList);
                    hs.Remove(choiseList[i]);
                }
           
            }
        }
    }
}
