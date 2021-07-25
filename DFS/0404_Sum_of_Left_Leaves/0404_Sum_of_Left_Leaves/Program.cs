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
    public int SumOfLeftLeaves(TreeNode root) {
        if(root == null) return 0;
        
        var resultList = new List<int>();
        resultList = DFS(root, false, resultList);
        
        return resultList.Sum();
    }
    
    private List<int> DFS(TreeNode node, bool isLeft, List<int> tempList)
    {
        if (node == null) return tempList;
        var resList = new List<int>(tempList);
        
        if (node.left == null && node.right == null) {
            if(isLeft) resList.Add(node.val);
            return resList;
        }
        
        resList = DFS(node.left, true, resList);
        resList = DFS(node.right, false, resList);
        
        return resList;
    }
}