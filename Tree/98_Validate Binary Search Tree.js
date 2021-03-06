// Given a binary tree, determine if it is a valid binary search tree (BST).

// Assume a BST is defined as follows:

// The left subtree of a node contains only nodes with keys less than the node's key.
// The right subtree of a node contains only nodes with keys greater than the node's key.
// Both the left and right subtrees must also be binary search trees.
// Example 1:

// Input:
//     2
//    / \
//   1   3
// Output: true
// Example 2:

//     5
//    / \
//   1   4
//      / \
//     3   6
// Output: false
// Explanation: The input is: [5,1,4,null,null,3,6]. The root node's value
//              is 5 but its right child's value is 4.


/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */
var isValidBST = function(root) {
    if(root === null){return true;}
    return CheckValidBST(root, Number.MIN_SAFE_INTEGER, Number.MAX_SAFE_INTEGER)
};

var CheckValidBST = function(node, lower, upper){
    if(node.val >= upper || node.val <= lower) return false;
    
    var status = true;
    if(node.left != null){
        status = status && CheckValidBST(node.left, lower, node.val);
    }

    if(node.right != null){
        status = status && CheckValidBST(node.right, node.val, upper);
    }
    return status;    
}