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
    public IList<int> PreorderTraversal(TreeNode root) {
        var result = new List<int>();
        if(root == null) return result;
        
        result = DFS(root, result);
        
        return result;
    }
    
    private List<int> DFS(TreeNode node, List<int> tmp)
    {
        if(node == null) return tmp;
        var result = new List<int>(tmp);

        result.Add(node.val);
        
        result = DFS(node.left, result);
        result = DFS(node.right, result);
        
        return result;
    }
}