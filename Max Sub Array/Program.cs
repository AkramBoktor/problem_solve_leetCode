using System;

namespace Max_Sub_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int currsum = nums[0];
            int maxsum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i] + currsum)
                {
                    currsum = nums[i] + currsum;

                }
                else
                {
                    currsum = nums[i];

                }
                maxsum = currsum < maxsum ? maxsum : currsum;

            }
            return maxsum;
        }
    }
}
