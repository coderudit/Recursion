using System;
using Recursion.Leetcode;

namespace Recursion.GFG
{
    class HeightOfBinaryTree
    {
        int FindHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = FindHeight(root.left);
            int rightHeight = FindHeight(root.right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
    
}
