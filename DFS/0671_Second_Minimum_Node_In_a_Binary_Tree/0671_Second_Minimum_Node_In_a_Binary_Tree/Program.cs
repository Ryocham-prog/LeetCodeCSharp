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
    public int FindSecondMinimumValue(TreeNode root) {
        if(root == null) return -1;
        
        var resultList = DFS(root);
        
        var result = resultList
            .Distinct()
            .OrderBy(x => x)
            .ElementAtOrDefault(1);
        
        if(result == 0) return -1;
        return result;
    }
    
    private List<int> DFS(TreeNode node)
    {
        if(node == null) return new List<int>();
        
        var tmpList = new List<int>();
        tmpList.Add(node.val);
     
        tmpList.AddRange(DFS(node.left));
        tmpList.AddRange(DFS(node.right));
        
        return tmpList;
    }
}