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
