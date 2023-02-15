/*
 Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the 
frequency
 of at least one of the chosen numbers is different.

The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

 

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:

Input: candidates = [2], target = 1
Output: []
*/

/*
 Follow the below steps to implement the idea:

Sort the array arr[] and remove all the duplicates from the arr[] then create a temporary vector r. to store every combination and a vector of vector res.
Recursively follow: 
If at any time sub-problem sum == 0 then add that array to the res (vector of vectors).
Run a while loop till the sum – arr[I] is not negative and i is less than arr.size().
Push arr[i] in r and recursively call for i and sum-arr[i] ,then increment i by 1.
pop r[i] from back and backtrack. 
Below is the implementation of the above approach.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _Meduim_CombinationSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = new int[] { 8,6,4,2 };

            int sum = 8;

            List<List<int>> ans
                = CombinationSum(arr, sum);

            // If result is empty, then
            if (ans.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            // print all combinations stored in ans

            for (int i = 0; i < ans.Count; i++)
            {

                Console.Write("(");
                for (int j = 0; j < ans[i].Count; j++)
                {
                    Console.Write(ans[i][j] + " ");
                }
                Console.Write(") ");
            }

        }

        public static List<List<int>> CombinationSum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> temp = new List<int>();

            HashSet<int> setOfArrays = new HashSet<int>(candidates.ToList());
            Array.Clear(candidates, 0, candidates.Length);
            candidates = setOfArrays.ToArray();
            Array.Sort(candidates);
            findCombination(result, candidates, target ,temp , 0);

            return result ;
        }

        private static void findCombination(List<List<int>> result, int[] candidates, int target ,List<int> temp , int index )
        {
            if( target == 0)
            {
                result.Add(new List<int>(temp));

                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if((target - candidates[i]) >= 0)
                {
                    temp.Add(candidates[i]);
                    findCombination(result, candidates, target - candidates[i], temp , i);
                    temp.Remove(candidates[i]);
                }
            }
        }
    }
}
