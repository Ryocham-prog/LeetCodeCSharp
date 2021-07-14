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
 // voidパターン(428 ms)
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        if(root == null) return result;
        
        DFS(root, result);
        
        return result;
    }
    
    private void DFS(TreeNode node, List<int> result)
    {
        if(node == null) return;
        
        DFS(node.left, result);
        result.Add(node.val);

        DFS(node.right, result);
    }
}
// ------------------------------------------------------

 // 戻り値Listパターン(240 ms)
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        if(root == null) return result;
        
        result = DFS(root, result);
        
        return result;
    }
    
    private List<int> DFS(TreeNode node, List<int> result)
    {
        if(node == null) return result;
        var ret = new List<int>(result);
        
        ret = DFS(node.left, result);
        ret.Add(node.val);
        ret = DFS(node.right, result);
        return ret;
    }
}