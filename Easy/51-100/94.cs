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
    private List<int> a = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        InorderTree(root);
        return a;
    }

    private void InorderTree(TreeNode root){
        if(root == null) return;

        InorderTraversal(root.left);
        a.Add(root.val);
        InorderTraversal(root.right);
    }
}