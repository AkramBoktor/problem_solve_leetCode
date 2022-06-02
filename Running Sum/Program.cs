using System;

namespace Running_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', Program.RunningSum(new int[] { 1, 2, 3, 4 }))); //1,3,6,10
            Console.WriteLine(string.Join(',', Program.RunningSum(new int[] { 1, 1, 1, 1, 1 }))); //1,2,3,4,5
            Console.WriteLine(string.Join(',', Program.RunningSum(new int[] { 3, 1, 2, 10, 1 }))); //3,4,6,16,17
        }


        public static int[] RunningSum(int[] nums)
        {
            int[] arrSum = new int[nums.Length];
            

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    arrSum[i] = arrSum[i] + nums[j];
                }
            }

            return arrSum;
        }
    }
}


/*LINQ
 *     public int[] RunningSum(int[] nums) {
        int total = 0;
        return nums.Select(x => total += x).ToArray();
    }*/

/*
 for (int i = 1; i < nums.Length; ++i) 
	{
		nums[i] += nums[i - 1]; 
	}
	return nums;
 
 */