﻿/*
 * 974. Subarray Sums Divisible by K
Medium
5.2K
200
Companies
Given an integer array nums and an integer k, return the number of non-empty subarrays that have a sum divisible by k.

A subarray is a contiguous part of an array.

 

Example 1:

Input: nums = [4,5,0,-2,-3,1], k = 5
Output: 7
Explanation: There are 7 subarrays with a sum divisible by k = 5:
[4, 5, 0, -2, -3, 1], [5], [5, 0], [5, 0, -2, -3], [0], [0, -2, -3], [-2, -3]
Example 2:

Input: nums = [5], k = 9
Output: 0
 

Constraints:

1 <= nums.length <= 3 * 104
-104 <= nums[i] <= 104
2 <= k <= 104
*/

using System;

namespace _Medium_SubarraysDivByK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.SubarraysDivByK(new int[] { 9 }, 5));
            Console.WriteLine(Program.SubarraysDivByK(new int[] { 4, 5, 0, -2, -3, 1 }, 5));
        }

        public static int SubarraysDivByK(int[] nums, int k)
        {
            #region Time Limit Exceeded

            if ( nums.Length == 0) return 0;
            
            if (nums.Length == 1 )
                return nums[0] % k == 0 ?  1 : 0;
            
            int count = 0;
            int sum = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                sum = nums[i];
                if (sum % k == 0) count++;
                for (int j = i+1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if( sum % k == 0)
                    {
                        count++;
                    }
                }
            }


            return count;

            #endregion
        }
    }
}
