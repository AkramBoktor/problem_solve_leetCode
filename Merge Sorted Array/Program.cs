using System;
using System.Linq;

namespace Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            Console.WriteLine(string.Join(",", Program.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3)));
            //Console.WriteLine(string.Join(",", Program.Merge(new int[] { 1 }, 1, new int[] { }, 0)));
            //Console.WriteLine(string.Join(",", Program.Merge(new int[] { 0 }, 0, new int[] { 1 }, 1)));
            //Console.WriteLine(string.Join(",", Program.Merge(new int[] { 1, 0 }, 1, new int[] { 2 }, 1)));
            //Console.WriteLine(string.Join(",", Program.Merge(new int[] { 2, 0 }, 1, new int[] { 1 }, 1)));
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
           
            int i = m-1;
            int j = n-1;
            int k = m+n-1;
            while(i>= 0 && j >= 0)
            {
                if(nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;

            }


            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }

            return nums1; 

        }
    }

}