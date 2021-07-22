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
    public int MinDiffInBST(TreeNode root) {
        if(root == null) return 0;
        
        var tmpList = new List<int>();
        tmpList = DFS(root, tmpList);
        
        var result = tmpList
            .Aggregate(100000, (minDiff, next) => {
                var calcResult = tmpList
                    .Aggregate(100000, (minDiff2, next2)=> {
                        if(next == next2) return minDiff2;
                        var tmp = next- next2;
                        var res = tmp < 0 ? tmp * -1 : tmp;
                        return Math.Min(res, minDiff2);
                    }) ;
                return Math.Min(calcResult, minDiff);
            });
        
        return result;
    }
    
    private List<int> DFS(TreeNode node, List<int> tmpList)
    {
        if(node == null) return tmpList;
        var resList = new List<int>(tmpList);
        
        resList.Add(node.val);
        
        resList = DFS(node.left, resList);
        resList = DFS(node.right, resList);
        
        return resList;
    }
}