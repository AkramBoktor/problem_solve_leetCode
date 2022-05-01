using System;
using System.Collections.Generic;

namespace Binary_Tree_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode();
            tree.val = 1;
            tree.left = new TreeNode();
            tree.left.left = null;
            tree.right = new TreeNode(2);
      
            tree.right.left = new TreeNode(3);

            Console.WriteLine(string.Join(',',Program.InorderTraversal(tree)));
            
        }

            // inorder  left root right
            // preorder root left right
            // postorder left right root
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> inOrderList = new List<int>();
            if (root != null)
            {
                InorderTraversal(root.left);
                inOrderList.Add(root.val);
                InorderTraversal(root.right);
            }
           

            return inOrderList;

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
