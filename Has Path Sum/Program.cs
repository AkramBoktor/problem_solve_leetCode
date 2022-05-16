using System;
using System.Collections.Generic;

namespace Has_Path_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode one = new TreeNode(1);
            one.right = new TreeNode(5);
            one.right.left = new TreeNode(2);


            one.left = new TreeNode(2);
            one.left.right = new TreeNode(7);
            Console.WriteLine(Program.HasPathSum(one,8));
        }

        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            if (root.val == targetSum && root.left == null && root.right == null)
                return true;
            else
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);




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
