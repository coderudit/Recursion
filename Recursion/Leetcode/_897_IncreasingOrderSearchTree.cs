using System.Collections.Generic;

namespace Recursion.Leetcode
{
    class _897_IncreasingOrderSearchTree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            List<int> vals = new();
            Inorder(root, ref vals);
            TreeNode ans = new TreeNode(0);
            TreeNode current = ans;
            foreach(var item in vals)
            {
                current.right = new TreeNode(item);
                current = current.right;
            }
            return ans.right;
        }

        public void Inorder(TreeNode node, ref List<int> vals)
        {
            if (node == null) return;
            Inorder(node.left, ref vals);
            vals.Add(node.val);
            Inorder(node.right, ref vals);
        }
    }
}
