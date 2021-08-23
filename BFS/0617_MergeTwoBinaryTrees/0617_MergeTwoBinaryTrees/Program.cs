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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if (root1 == null) return root2; // Null check
        
        var queue = new Queue<(TreeNode, TreeNode)>(); // Queue for processing
        queue.Enqueue((root1,root2)); // Seed Data
        
        while(queue.Count != 0){
            (TreeNode currT1, TreeNode currT2) curr = queue.Dequeue();
            
            
            if(curr.currT1 != null && curr.currT2 != null){
                // 両方のvalがnot nullの場合
                curr.currT1.val = curr.currT1.val + curr.currT2.val; 
                
                if(curr.currT1.left != null && curr.currT2.left != null)
                {
                    // root1, roo2のleftがnot null
                    queue.Enqueue((curr.currT1.left, curr.currT2.left));
                }
                else if (curr.currT2.left != null)
                {
                    // roo2のみleftがnot null
                    curr.currT1.left = curr.currT2.left;
                }
                
                if (curr.currT1.right != null && curr.currT2.right != null)
                {
                    // root1, roo2のrightがnot null
                    queue.Enqueue((curr.currT1.right, curr.currT2.right)); 
                }
                else if (curr.currT2.right != null)
                {
                    // roo2のみrightがnot null
                    curr.currT1.right = curr.currT2.right;
                }
            }
        }
        return root1;        
    }
}