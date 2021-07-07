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
    public int SumRootToLeaf(TreeNode root) {
        if(root == null) return 0;
        
        var result = 0;
        var tmp = String.Empty;
        
        DFS(root, ref result, tmp);
        
        return result;
    }
    
    private void DFS(TreeNode node, ref int result, string tmp)
    {
        if(node == null) return;
        tmp += node.val.ToString();
        
        if(node.left == null && node.right == null) {
            result += Convert.ToInt32(tmp, 2);
            return;
        }
        
        DFS(node.left, ref result, tmp);
        DFS(node.right, ref result, tmp);
           
    }
}