/*You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with 
that node. If such a node does not exist, return null.
*/

namespace Assignment7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            TreeNode root = null;

            root = solution.InsertIntoBST(root, 5);
            root = solution.InsertIntoBST(root, 3);
            root = solution.InsertIntoBST(root, 7);
            root = solution.InsertIntoBST(root, 2);
            root = solution.InsertIntoBST(root, 4);
            root = solution.InsertIntoBST(root, 6);
            root = solution.InsertIntoBST(root, 8);

            solution.DisplayBST(root);
            Console.WriteLine();
        }
        public class TreeNode
        {
            public int value;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int nodeValue = 0, TreeNode leftNode = null, TreeNode rightNode = null)
            {
                value = nodeValue;
                left = leftNode;
                right = rightNode;
            }
        }

        public class Solution
        {
            public TreeNode InsertIntoBST(TreeNode root, int val)
            {
                if (root == null)
                {
                    return new TreeNode(val);
                }
                if (val < root.value)
                {
                    root.left = InsertIntoBST(root.left, val);
                }
                else
                {
                    root.right = InsertIntoBST(root.right, val);
                }
                return root;
            }
            public void DisplayBST(TreeNode root, int space = 0, int increment = 5)
            {
                if (root == null)
                    return;

                space += increment;

                DisplayBST(root.right, space);

                Console.Write("\n");
                for (int i = increment; i < space; i++)
                    Console.Write(" ");
                Console.Write(root.value + "\n");

                DisplayBST(root.left, space);
            }
        }
    }
}
