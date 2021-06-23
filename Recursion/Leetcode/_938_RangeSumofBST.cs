namespace Recursion.Leetcode
{
    class _938_RangeSumofBST
    {
        private int sum = 0;
        public int RangeSumBST(TreeNode node, int low, int high)
        {
            if (node == null)
            {
                return 0;
            }
            if (low <= node.val && node.val <= high)
            {
                sum += node.val;
            }
            if (low < node.val)
            {
                RangeSumBST(node.left, low, high);
            }
            if (node.val < high)
            {
                RangeSumBST(node.right, low, high);
            }
            return sum;
        }
    }

    class TreeNode
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
