using System;
using System.Collections.Generic;

namespace Is_Symmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode one = new TreeNode(1);
            one.right = new TreeNode(2);
            one.right.left = new TreeNode(3);

            one.left = new TreeNode(2);
            one.left.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(one));
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return recursive(root.left, root.right);
        }

        public static bool recursive(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left == null || right == null)     // left=null, right!= null or left!=null, right=null
                return false;

            if (left.val != right.val)
                return false;

            return recursive(left.left, right.right) && recursive(left.right, right.left);
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
