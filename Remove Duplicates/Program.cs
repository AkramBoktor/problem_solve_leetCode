using System;
using System.Collections.Generic;

namespace Remove_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.RemoveDuplicates(new int[] { 1, 1, 2 }));
            Console.WriteLine(Program.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }

        public static int RemoveDuplicates(int[] nums)
        {
            //int countOfNonRepeat = 0;

            //for (int i = 1; i < nums.Length; i++)

            //{
            //    if(nums[i]!= nums[countOfNonRepeat])
            //    {
            //        nums[++countOfNonRepeat] = nums[i];
            //    }
            //}

            //return countOfNonRepeat+1;
            HashSet<int> countNumber = new HashSet<int>();

            foreach (var item in nums)
            {
                countNumber.Add(item);
            }
            countNumber.CopyTo(nums);
            return countNumber.Count;
        }
    }
}
