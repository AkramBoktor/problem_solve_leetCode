using System;
using System.Collections.Generic;
using System.Linq;

namespace Is_Same_Tree
{
    class Program
    {
		static void Main(string[] args)
		{
			TreeNode one = new TreeNode(1);
			one.left = new TreeNode(3);
			//one.right = new TreeNode(1);

			TreeNode two = new TreeNode(1);
			two.left = new TreeNode(3);

			Console.WriteLine(Program.IsSameTree(one,two));
		}

		public static bool IsSameTree(TreeNode p, TreeNode q)
		{

			List<int> _resultP = new List<int>();
			List<int> _resultQ = new List<int>();
			TraverseWithInorderOne(p, _resultP);
			TraverseWithInorderOne(q, _resultQ);
			return Enumerable.SequenceEqual(_resultP,_resultQ);
		}

		private static void TraverseWithInorderOne(TreeNode root,List<int> result)
		{
			if (root != null )
			{
				TraverseWithInorderOne(root.left ,result);
				result.Add(root.val);
				TraverseWithInorderOne(root.right, result);
			}
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

