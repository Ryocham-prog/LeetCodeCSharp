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
    public int RangeSumBST(TreeNode root, int low, int high) {
        
        if (root == null) return 0;

        var sum = 0;
        // 計算範囲の最小値より小さい場合
        if (root.val < low)
            sum += RangeSumBST(root.right, low, high);
        // 計算範囲の最小値より大きい場合
        else if (root.val > high)
            sum += RangeSumBST(root.left, low, high);
        // 計算対象の場合
        else
        {
            sum += root.val;
            sum += RangeSumBST(root.left, low, high);
            sum += RangeSumBST(root.right, low, high);
        }

        return sum;      

    }
}