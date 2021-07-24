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
    public int FindTilt(TreeNode root) {
        if(root == null) return 0;
        
        var resultList = new List<int>();
        var tmp = DFS(root, resultList);
        var result = resultList.Sum();
        
        return result;
    }
    
    private int DFS(TreeNode node, List<int> resultList)
    {
        if(node == null) return 0;
        
        var leftVal = node.left == null ? 0 : DFS(node.left, resultList);
        var rightVal = node.right == null ? 0 : DFS(node.right, resultList);
        resultList.Add(Math.Abs(leftVal - rightVal)); 
        
        return node.val + leftVal + rightVal;
    }
}