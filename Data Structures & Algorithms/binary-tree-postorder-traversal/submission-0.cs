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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        
        void Postorder (TreeNode node) {
            if (node == null) {
                return;
            }

            Postorder(node.left);
            Postorder(node.right);
            res.Add(node.val);
        }

        Postorder(root);
        return res;
    }
}