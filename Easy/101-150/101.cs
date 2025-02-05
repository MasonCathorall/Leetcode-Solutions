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
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        return isSymmetric(root.left, root.right);
    }
    private bool isSymmetric(TreeNode p, TreeNode q) {
        if(p == null || q == null) return p == q;
        if(p.val != q.val) return false;
        
        return isSymmetric(p.left, q.right) && isSymmetric(p.right, q.left);
    }
}