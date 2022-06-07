using System;
using System.Linq;
namespace Next_Greater_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Program.NextGreaterElement(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 })));
            Console.WriteLine(string.Join(",", Program.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 })));
            Console.WriteLine(string.Join(",", Program.NextGreaterElement(new int[] { 1,3,5,2,4 }, new int[] { 6,5,4,3,2,1,7})));
        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] nextGreaterElement = new int[nums1.Length];
            int valueOfIndex = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                valueOfIndex = nums1[i];
              int indexOfElement = nums2.Select((s, i) => new { i, s })
                                         .Where(t => t.s == valueOfIndex)
                                         .Select(t => t.i)
                                         .FirstOrDefault();
                if(indexOfElement == nums2.Length - 1)
                {
                    nextGreaterElement[i] = -1;
                }
                else
                {
                    for (int j = indexOfElement+1; j <= nums2.Length-1 ; j++)
                    {
                        if(nums2[j] > valueOfIndex)
                        {
                            nextGreaterElement[i] = nums2[j];
                            break;
                        }
                        else
                        {
                            nextGreaterElement[i] = -1;
                        }
                    }

                }
            }

            return nextGreaterElement;
        }
    }
}

/*
 Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
Output: [-1,3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
- 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
- 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
=====================================
Input: nums1 = [2,4], nums2 = [1,2,3,4]
Output: [3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 2 is underlined in nums2 = [1,2,3,4]. The next greater element is 3.
- 4 is underlined in nums2 = [1,2,3,4]. There is no next greater element, so the answer is -1.
 */