/*
 Given an integer array nums, return all the different possible non-decreasing subsequences of the given array with at least two elements. You may return the answer in any order.

 

Example 1:

Input: nums = [4,6,7,7]
Output: [[4,6],[4,6,7],[4,6,7,7],[4,7],[4,7,7],[6,7],[6,7,7],[7,7]]
Example 2:

Input: nums = [4,4,3,2,1]
Output: [[4,4]]
 

Constraints:

1 <= nums.length <= 15
-100 <= nums[i] <= 100
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _Medium_Non_decreasing_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.FindSubsequences(new int[] {4,6,7,7}));
        }

        public static IList<IList<int>> FindSubsequences(int[] nums)
        {
            HashSet<List<int>> Subsequences = new HashSet<List<int>>();
            HashSet<List<int>> newSubsequences = new HashSet<List<int>>();
            List<int> subList = new List<int>();
            List<int> appendedList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                subList.Add(nums[i]);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        var itemappend = subList.Append(nums[j]);
                        Subsequences.Add(itemappend.ToList());
                        if (Subsequences.Count >= 2)
                        {
                            foreach (var item in Subsequences)
                            {
                               var appendedItem =  item.Append(nums[j]);
                                if (Subsequences.Contains(appendedItem)) continue;
                                else
                                {
                                    appendedList.AddRange(appendedItem);
                                    newSubsequences.Add(appendedList);
                                }

                            }



                        }

                       

                    }
                }
                subList = null;
            }
            Subsequences.UnionWith(newSubsequences);
            return (IList<IList<int>>)Subsequences;
        }
    }
}
