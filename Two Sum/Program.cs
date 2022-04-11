using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("," ,Program.TwoSum(new int[]{ 3,2,4 },6)));
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> arrayList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        arrayList.Add(i);
                        arrayList.Add(j);
                        return arrayList.ToArray();
                    }
                }
            }
            return Array.Empty<int>();
        }

            //    if (nums == null || nums.Length < 2)
            //        return new int[2];

            //    Dictionary<int, int> dic = new Dictionary<int, int>();

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (dic.ContainsKey(target - nums[i]))
            //            return new int[] { i, dic[target - nums[i]] };
            //        else if (!dic.ContainsKey(nums[i]))
            //            dic.Add(nums[i], i);
            //    }

            //    return new int[2];
            //}
        }
}
