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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) return false;
        
        if (root.val == subRoot.val && DFS(root, subRoot)) return true;
        
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    
    private bool DFS(TreeNode node, TreeNode subNode)
    {
        if(node == null && subNode == null) return true;
        
        if((node != null && subNode == null) || (node == null && subNode != null)) return false;
        
        return node.val == subNode.val && DFS(node.left, subNode.left) && DFS(node.right, subNode.right);
    }
}