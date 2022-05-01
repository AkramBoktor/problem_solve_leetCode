using System;
using System.Collections.Generic;

namespace Binary_Tree_Inorder_Traversal
{
	class Program
	{
		// indoreorder left root right
		// preorder root left right
		// postorder left right root
		static void Main(string[] args)
		{
			TreeNode one = new TreeNode(1);
			one.right = new TreeNode(2);
			one.right.left = new TreeNode(3);
			
			Console.WriteLine(string.Join(",", Program.InorderTraversal(one)));
		}

		public static IList<int> InorderTraversal(TreeNode root)
        {
			List<int> _result = new List<int>();
			TraverseWithInorder(root ,_result);
			return _result;
		}

			private static void TraverseWithInorder(TreeNode root, List<int> result)
		{
			if (root != null)
			{
				TraverseWithInorder(root.left, result);
				result.Add(root.val);
				TraverseWithInorder(root.right, result);
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

