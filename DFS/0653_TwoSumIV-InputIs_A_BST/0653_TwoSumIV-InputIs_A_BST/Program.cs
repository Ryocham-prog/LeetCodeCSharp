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

 // Aggregateをあえてつかってみる
public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        if(root == null || (root.left == null && root.right == null)) return false;
        
        var valList = new List<int>();        
        valList = DFS(root, valList);
        
        var result = valList
            .OrderBy(x => x)
            .ToList()
            .Aggregate(false, (judge, next) => {
                if(judge == true) return judge;
                
                var target = valList.Where(x => x != next).ToList();
                if(target.Where(x => x ==(k - next)).Count() > 0) return true;

                return judge;
            });
        
        return result;
    }
    
    private List<int> DFS(TreeNode node, List<int> tmp)
    {
        if(node == null) return tmp;
        var res = new List<int>(tmp);

        res.Add(node.val);
        
        res = DFS(node.left, res);
        res = DFS(node.right, res);
        
        return res;
    }
}