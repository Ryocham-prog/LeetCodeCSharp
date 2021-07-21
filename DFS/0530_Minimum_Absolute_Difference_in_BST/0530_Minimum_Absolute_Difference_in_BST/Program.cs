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

// 187/188でタイムアウトになったので、後日改善する。
// (nodeの数が多いとタイムアウトになる。)
public class Solution {
    public int GetMinimumDifference(TreeNode root) {
        if(root == null) return 0;

        var tmpList = new List<decimal>();
        tmpList = DFS(root, tmpList);
        
        var result = tmpList
            .Aggregate(100000, (minDiff, next) => {
                var calcResult = tmpList
                    .Aggregate(100000, (minDiff2, next2) =>{
                        if(next == next2) return minDiff2;
                        
                        var tmp = Math.Abs(next - next2);
                        return Math.Min((int)tmp, minDiff2);
                    });

                return Math.Min((int)calcResult, minDiff);                
            });
        return result;    
    }
    
    private List<decimal> DFS(TreeNode node, List<decimal> tmpList)
    {
        if(node == null) return tmpList;
        var resList = new List<decimal>(tmpList);
        
        resList.Add(node.val);
        
        resList = DFS(node.left, resList);
        resList = DFS(node.right, resList);
        
        return resList;
    }
}