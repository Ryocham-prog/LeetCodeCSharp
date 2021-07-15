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
    public IList<double> AverageOfLevels(TreeNode root) {
        var result = new List<double>();
        if(root == null) return result;

        var count = new List<int>();
        DFS(root, 0, result, count);
        
        for(var idx = 0; idx < result.Count(); idx++)
        {
            var ave = result[idx] / count[idx];
            result[idx] = ave; 
        }
        
        return result;
    }
    
    private void DFS(TreeNode node,int i, List<double> tmp, List<int> count)
    {
        if(node == null) return;
        if(i < tmp.Count()){
            tmp[i] += node.val;
            count[i] += 1; 
        } else {
            tmp.Add(node.val);
            count.Add(1);
        }
        
        DFS(node.left, i+1, tmp, count);
        DFS(node.right,i+1, tmp, count);
    }
}