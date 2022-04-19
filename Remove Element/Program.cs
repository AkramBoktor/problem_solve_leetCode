using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
            Console.WriteLine(Program.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            List<int> numsSorted = new List<int>();
            numsSorted.AddRange(nums);
            numsSorted = numsSorted.Where(x => x != val).ToList();
            nums = numsSorted.ToArray();
            return numsSorted.Count;
            /**********************************************/
            // if (nums.Length == 0) return 0;
            //nums=  nums.Where(x => x != val).ToArray();

            // return nums.Length;
            /*************************************************/
            //int countofElement = 0;
            //int j = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] !=val)
            //    {
            //        int temp = nums[j];
            //        nums[j] = nums[i];
            //        nums[i] = temp;
            //        j++;
            //    }
            //}

            //return j;
        }
    }
}
