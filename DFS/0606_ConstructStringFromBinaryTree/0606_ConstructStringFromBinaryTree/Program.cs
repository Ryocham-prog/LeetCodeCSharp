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
    public string Tree2str(TreeNode root) {
        var result = new StringBuilder();
        result = DFS(root, result);
        
        return result.ToString();
    }
    
    private StringBuilder DFS(TreeNode node, StringBuilder tmp)
    {
        if(node == null) return tmp;
        
        tmp.Append($"{node.val}");
        
        if(node.left == null && node.right == null) return tmp;
        
        tmp.Append("(");
        tmp = DFS(node.left, tmp);
        tmp.Append(")");
        
        if(node.right != null)
        {
            tmp.Append("(");
            tmp = DFS(node.right, tmp);
            tmp.Append(")");
        }
        return tmp;
    }
}