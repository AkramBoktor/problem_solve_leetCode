using System;

namespace Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',',Program.SortArrayByParity(new int[] { 4,3,2,1 })));
            Console.WriteLine(string.Join(',',Program.SortArrayByParity(new int[] { 4,4,2,1 })));
        }

        public static int[] SortArrayByParity(int[] nums)
        {
            if (nums.Length == 1) return nums;
            int[] sortedArrayParity = new int[nums.Length];
            int startIndex = 0;
            int endIndex = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 != 0)
                {
                    sortedArrayParity[nums.Length - endIndex] = nums[i];
                    endIndex++;
                }
                else
                {
                    sortedArrayParity[startIndex] = nums[i];
                    startIndex++;
                }
            }
           
            Array.Copy(sortedArrayParity, nums, nums.Length);
            return nums;
        }
    }
}
