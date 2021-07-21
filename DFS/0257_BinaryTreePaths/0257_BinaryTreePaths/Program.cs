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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var result = new List<string>();
        if(root == null) return result;
        
        result = DFS(root, result, "");
        
        return result;
    }
    
    private List<string> DFS(TreeNode node, List<string> tmpList, string tmpStr)
    {
        if(node == null) return tmpList;
        
        var resList = new List<string>(tmpList);
        var resStr = tmpStr + node.val;
        
        if(node.left == null && node.right == null) 
        {
            resList.Add(resStr);
            return resList;
        }
        
        resStr = resStr + "->";
        
        resList = DFS(node.left, resList, resStr);
        resList = DFS(node.right, resList, resStr);
        
        return resList;
    }
}