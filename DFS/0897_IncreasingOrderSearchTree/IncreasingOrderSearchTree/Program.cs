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
    public TreeNode tmp;
    
    public TreeNode IncreasingBST(TreeNode root) {
        var result = new TreeNode(0);
        tmp = result;
        
        RemakeTree(root);
        
        // ↓偶然の産物。何故resultが期待値になるのかが理解できない。(要理解)

        // val=0の情報が不要なので、rightのみをreturn
        return result.right;
    }
    
    private void RemakeTree(TreeNode node)
    {
        if(node == null) return;
        
        RemakeTree(node.left);
        node.left = null;

        tmp.right = node;
        tmp = tmp.right;

        RemakeTree(node.right);
    }
}