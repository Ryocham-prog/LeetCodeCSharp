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
    public int[] FindMode(TreeNode root) {
        var valList = DFS(root);
        
        // 同じvalueをグループ化
        var countList = valList
            .GroupBy(x => x)
            .Select(x => new {val = x, count = x.Count()})
            .OrderByDescending(x => x.count);

        // 一番多い数を取得
        var maxCount = countList
            .ElementAtOrDefault(0)
            .count;
        
        var result = countList
            .Where(x => x.count == maxCount)
            .SelectMany(x => x.val)
            .Distinct()
            .ToArray();
        
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