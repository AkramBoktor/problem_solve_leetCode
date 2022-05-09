using System;
using System.Collections.Generic;

namespace Maximum_Depth_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
			TreeNode one = new TreeNode(1);
            one.right = new TreeNode(2);
            //one.right.left = new TreeNode(3);

            one.left = new TreeNode(2);
            one.left.right = new TreeNode(3);

			Console.WriteLine(string.Join(",", Program.MaxDepth(one)));
		}

		public static int MaxDepth(TreeNode root)
		{			
			 
			return MaxDepthCount(root);
		}

		private static int MaxDepthCount(TreeNode root )
		{
			if (root == null)
            {
				return 0;

			}
			else
            {
				int maxL = MaxDepthCount(root.left);
				int maxR = MaxDepthCount(root.right);
				return maxL >= maxR ? maxL + 1 : maxR + 1;
			}
				
			
		
			
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
