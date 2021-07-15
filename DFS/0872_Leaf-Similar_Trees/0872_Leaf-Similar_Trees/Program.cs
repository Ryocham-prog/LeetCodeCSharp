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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        if(root1 == null && root2 == null) return false;
        
        var root1Arr = new List<int>();
        var root2Arr = new List<int>();
        
        root1Arr = DFS(root1, root1Arr);
        root2Arr = DFS(root2, root2Arr);
        
        return root1Arr.SequenceEqual(root2Arr);
    }
    
    private List<int> DFS(TreeNode node, List<int> rootArr)
    {
        if(node == null) return rootArr;
        var tmpArr = new List<int>(rootArr);
        
        if(node.left == null && node.right == null) tmpArr.Add(node.val);
        
        tmpArr = DFS(node.left, tmpArr);
        tmpArr = DFS(node.right, tmpArr);
 
        return tmpArr;
    }
}