using System;

namespace Search_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.SearchInsert(new int[] { 1, 3, 4, 5 }, 2));
            Console.WriteLine(Program.SearchInsert(new int[] { 1, 3, 4, 5 }, 3));
            Console.WriteLine(Program.SearchInsert(new int[] { 1, 3, 4, 5 }, 0));
        }

        public static int SearchInsert(int[] nums, int target)
        {
            //if (nums == null || target == 0) return -1;
            //int j = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    j = i + 1;
            //    if (nums[i] == target) return i;

            //    if (target > nums[i] && target < nums[j])
            //    {
            //        return j;
            //    }
            //}

            //return -1;
            if (nums == null ) return -1;
            int start = 0;
            int end = nums.Length - 1;
                while (end - start >= 0)
            {
                int mid = (start + end) / 2;

                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return start;
        }
    }
}
