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
    public bool IsCousins(TreeNode root, int x, int y) {
        if(root == null) return false;

        var infoList = new List<int>();
        infoList = DFS(root, 0, 0, x, y, infoList);

        if(infoList.Count < 4) return false;

        return ((infoList[0] == infoList[2]) && (infoList[1] != infoList[3]));
    }
    
    private List<int> DFS(TreeNode node, int nowDepth, int nowParentVal, int x, int y, List<int> infoList)
    {
        if(node == null || infoList.Count == 4 ) return infoList;

        var tmpList = new List<int>(infoList);
        if(node.val == x || node.val == y)
        {
            tmpList.Add(nowDepth);
            tmpList.Add(nowParentVal);
        }
        
        return DFS(node.right, nowDepth + 1, node.val, x, y, DFS(node.left, nowDepth + 1, node.val,  x, y, tmpList));
    }
}