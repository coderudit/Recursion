namespace Recursion.Leetcode
{
    class _897_IncreasingOrderSearchTree
    {
        private static TreeNode baseRoot;
        public TreeNode IncreasingBST(TreeNode root)
        {
            if(root == null)
            {
                baseRoot = new TreeNode();
                return baseRoot;
            }
            
            var node = IncreasingBST(root.left);
            node.right = new TreeNode { val=  root.val};
            IncreasingBST(root.right);
            return node;
        }
    }
}
