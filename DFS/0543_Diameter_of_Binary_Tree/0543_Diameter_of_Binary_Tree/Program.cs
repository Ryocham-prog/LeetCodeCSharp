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
    public int DiameterOfBinaryTree(TreeNode root) {
        var maxDiameter = 0;
        DFS(root, ref maxDiameter);
        return maxDiameter;
    }
    
    private int DFS(TreeNode node, ref int maxDiameter)
    {
        if (node == null) return 0;
           
        if (node.left == null && node.right == null) return 0;

        var leftVal = DFS(node.left, ref maxDiameter);
        var rightVal = DFS(node.right, ref maxDiameter);
        var addVal = (node.left == null || node.right == null) ? 1 : 2;
        
        if (leftVal + rightVal + addVal > maxDiameter) {
            maxDiameter = leftVal + rightVal + addVal;
        }
        
        return Math.Max(leftVal, rightVal) + 1;
    }
}