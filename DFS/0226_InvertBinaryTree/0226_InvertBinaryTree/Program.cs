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
    public TreeNode InvertTree(TreeNode root) {
        var result = root;
        if(root == null) return null;

        var dummyR = InvertTree(root.right);
        var dummyL = InvertTree(root.left);
        
        result.left = dummyR;
        result.right = dummyL;
        
        return result;
    }
}