using System;

namespace Convert_Sorted_Array_to_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", Program.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 })));
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            var n = nums.Length;
            return DFS(nums, 0, n - 1);
        }

        private static TreeNode DFS(int[] nums, int left, int right)
        {
            if (left > right) return null;
            var mid = left + (right - left) / 2;
            var root = new TreeNode(nums[mid]);
            root.left = DFS(nums, left, mid - 1);
            root.right = DFS(nums, mid + 1, right);
            return root;
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
