
/*Given an integer array nums, 
    move all 0's to the end of it while maintaining the relative order 
    of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0, 1, 0, 3, 12]
Output:[1,3,12,0,0]
Example 2:

Input: nums = [0]
Output:[0]
*/
using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.MoveZeroes(new int[] { 0 , 0 , 1 , 1});
        }

        public static  void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0 || nums == null) return;
            if (nums.Length == 1) Console.WriteLine(String.Join(',', nums));

            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    nums[length-1] = 0;
                    i--;
                    length--;
                }
            }

            Console.WriteLine(String.Join(',', nums));
        }

    }
}
