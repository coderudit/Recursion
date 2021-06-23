using System;

namespace Recursion.Leetcode
{
    class _104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            return MaxDepthRecursive(root, 0);
        }

        int MaxDepthRecursive(TreeNode root, int depth)
        {
            if (root == null)
                return depth;
            else
                depth++;
            return Math.Max(MaxDepthRecursive(root.left, depth), MaxDepthRecursive(root.right, depth));
        }
    }
}
