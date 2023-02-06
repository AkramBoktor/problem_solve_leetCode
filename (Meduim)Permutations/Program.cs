/*
 Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
Example 2:

Input: nums = [0,1]
Output: [[0,1],[1,0]]
Example 3:

Input: nums = [1]
Output: [[1]]
 
   Explain : https://www.youtube.com/watch?v=bQuh118vfF8
             https://www.youtube.com/watch?v=H232aocj7bQ&t=1000s
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _Meduim_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Permute(new int[] { 1 , 2 , 3 }));
        }

        public static  IList<IList<int>> Permute(int[] nums)
        {
            var premuteList = new List<IList<int>>();
            Premutations(nums.ToList(), new List<int>(), premuteList);

            return premuteList;
        }

        private static void Premutations(List<int> choice, List<int> workingList, List<IList<int>> premuteList)
        {
            if(choice.Count == 0){
                premuteList.Add(new List<int>(workingList));
            }

            for (int i = 0; i < choice.Count; i++)
            {
                var valueVisit = choice[i];
                workingList.Add(valueVisit);
                choice.RemoveAt(i);
                Premutations(choice,workingList,premuteList);

                choice.Insert(i,valueVisit);
                workingList.Remove(valueVisit);
            }
        }
    }
}


/* 
 * another solution dfs
 * public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        
        List<IList<int>> res = new List<IList<int>>();
        Backtracking(nums, new List<int>(), res);
        return res;
    }
    
    private void Backtracking(int[] nums, List<int> list, List<IList<int>> res)
    {
        if(list.Count == nums.Length)
        {
            res.Add(new List<int>(list));
            return;
        }
        else
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(list.Contains(nums[i]))
                    continue;
                list.Add(nums[i]);
                Backtracking(nums, list, res);
                list.RemoveAt(list.Count -1);
            }
        }
    }
}
*/