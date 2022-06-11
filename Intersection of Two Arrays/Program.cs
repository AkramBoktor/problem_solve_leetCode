using System;
using System.Linq;
namespace Intersection_of_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Program.Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
            Console.WriteLine(string.Join(",", Program.Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
            Console.WriteLine(string.Join(",", Program.Intersection(new int[] { 6, 6, 4, 4, 0, 0, 8, 1, 2 }, new int[] { 6 })));
        }
      
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var numbersIntersection = nums1.Where(n => n == (nums2.Contains(n) == true? n : null)).Distinct().ToArray();
            return numbersIntersection;

            //var numbers = (from n1 in nums1
            //               join n2 in nums2
            //               on n1 equals n2
            //               select n2).Distinct().ToArray();

            //return numbers;
        }
    }
}


/*Examoles
 * Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.
*/