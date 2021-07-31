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
    public bool IsSymmetric(TreeNode root) {
        
        var result = DFS(root.left, root.right);
        
        return result;
    }
    
    private bool DFS(TreeNode nodeLeft, TreeNode nodeRight)
    {
        if(nodeLeft == null && nodeRight == null) return true;

        if((nodeLeft == null && nodeRight != null) || 
           (nodeLeft != null && nodeRight == null)) return false;
        
        if(nodeLeft.val != nodeRight.val) return false;
        
        var boolL = DFS(nodeLeft.left, nodeRight.right);
        var boolR = DFS(nodeLeft.right, nodeRight.left);
        
        return boolL && boolR;
    }
}