// ToOffer_6
// Given preorder and inorder traversal of a tree, construct the binary tree.

// Note:
// You may assume that duplicates do not exist in the tree.

// For example, given

// preorder = [3,9,20,15,7]
// inorder = [9,3,15,20,7]
// Return the following binary tree:

//     3
//    / \
//   9  20
//     /  \
//    15   7

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildTreeRecursively(preorder, 0, preorder.Length -1, 
                                    inorder, 0, inorder.Length -1);
    }
    
    public TreeNode BuildTreeRecursively
        (int[] preorder, int preFrom, int preTo, 
         int[] inorder, int inFrom, int inTo)
    {
        if(preorder == null 
           || inorder == null 
           || preTo - preFrom < 0 
           || inTo - inFrom < 0)
        {
            return null;
        }
        
        var root = new TreeNode(preorder[preFrom]);
        var inOrderIndex = FindANode(inorder, inFrom, inTo, root.val);
        
        var leftSubTreeCnt = inOrderIndex - inFrom;
        
        root.left = BuildTreeRecursively
            (preorder, preFrom + 1, preFrom + leftSubTreeCnt, 
             inorder, inFrom , inOrderIndex - 1 );
        root.right = BuildTreeRecursively
            (preorder, preFrom + 1 +  leftSubTreeCnt, preTo, 
             inorder, inOrderIndex + 1, inTo );
        
        return root;
    }
    
    public int FindANode(int[] order, int fromIndex, int toIndex, int val)
    {
        for(int i = fromIndex; i <= toIndex ; i++)
        {
            if(order[i] == val)
            {
                return i;
            }
        }
        return fromIndex;
    }
}