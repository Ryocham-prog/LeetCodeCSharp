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
    public bool IsUnivalTree(TreeNode root) {
        if(root.left == null && root.right == null) return true;

        var valList = new List<int>();
        DFS(root, valList);
        
        return valList.GroupBy(x => x).Count() == 1;
    }
    
    private void DFS(TreeNode node, List<int> valList)
    {
        if(node == null) return;
        valList.Add(node.val);
        
        DFS(node.left, valList);
        
        DFS(node.right, valList);
    }
}