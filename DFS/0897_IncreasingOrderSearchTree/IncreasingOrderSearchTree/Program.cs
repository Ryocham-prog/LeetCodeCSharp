/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        TreeNode prevNode = new TreeNode(-1);
        TreeNode newRoot = new TreeNode(-1);
        
        InOrder(root, ref prevNode, ref newRoot);
        
        return newRoot;
    }
    
    public static void InOrder(TreeNode root, ref TreeNode prevNode, ref TreeNode newRoot)
    {
        if (root == null) return;
        
        InOrder(root.left, ref prevNode, ref newRoot);
        
        if (prevNode.val == -1)
        {
            newRoot = new TreeNode(root.val);
            prevNode = newRoot;
        }
        else
        {
            prevNode.right = new TreeNode(root.val);
            prevNode = prevNode.right;
        }
        
        InOrder(root.right, ref prevNode, ref newRoot);

    }
}