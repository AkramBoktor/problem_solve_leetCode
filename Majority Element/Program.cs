using System;
using System.Linq;
namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.MajorityElement(new int[] { 3, 2, 3 }));
            Console.WriteLine(Program.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }


        public static int MajorityElement(int[] nums)
        {
            double repeatedCountNumber = Convert.ToDouble(nums.Length / 2) + 1;

           int repeatedNumberinArray =  nums.GroupBy(num => num).Where(n => n.Count() >= repeatedCountNumber).Select(x => x.Key).FirstOrDefault();

            return repeatedNumberinArray;
        }
    }
}

/**************************/
/*
     Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach (var n in nums)
        {
            if (!dict.ContainsKey(n))
                dict.Add(n, 0);
            
            dict[n] += 1;
            
            if (dict[n] > nums.Length / 2)
                return n;
        }
        
        return -1;

*/

/*
 Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
 

Follow-up: Could you solve the problem in linear time and in O(1) space?
*/