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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        
        var result = true;
        DFS(root, ref result);
        
        return result;
    }
    
    private int DFS(TreeNode node, ref bool result)
    {
        if(node == null || result == false) return 0;
        
        var leftDepth = DFS(node.left, ref result);
        var rightDepth = DFS(node.right, ref result);
        
        if(Math.Abs(leftDepth - rightDepth) > 1) result = false;
        
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}