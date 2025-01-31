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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;

        int depth = 0;

        Queue<TreeNode> q = new Queue<TreeNode>();

        q.Enqueue(root);

        while(q.Count > 0){
            int levelSize = q.Count;
            for(int i = 0; i < levelSize; i ++){
                TreeNode curr = q.Dequeue();

                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
            }
            depth++;
        }

        return depth;
    }
}