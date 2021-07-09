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
    public int MaxDepth(TreeNode root) {
        var result = 0;
        if(root == null) return result;
        
        DFS(root, 0, ref result);
        
        return result;
    }
    
    private void DFS(TreeNode node, int tmp, ref int result){
        if(node == null) return;
        tmp++;
        
        if(node.left == null && node.right == null){
            if(tmp > result) result = tmp ;
            return;
        } 
        
        DFS(node.left, tmp, ref result);
        DFS(node.right, tmp, ref result);
    }
}