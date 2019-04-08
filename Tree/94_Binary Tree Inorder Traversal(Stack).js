// Given a binary tree, return the inorder traversal of its nodes' values.

// Example:

// Input: [1,null,2,3]
//    1
//     \
//      2
//     /
//    3

// Output: [1,3,2]
// Follow up: Recursive solution is trivial, could you do it iteratively?


/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var inorderTraversal = function(root) {
    var res = [];
    var stack = [];
    var pointer = root;
    
    while(pointer != null || stack.length != 0){
        while(pointer != null){ 
            // important here: all items get in pushed in stack, even the leaf nodes. 
            // So that when a node is poped out of a stack, we konw for sure it's left sub tree has been dealt with.
            stack.push(pointer)
            pointer = pointer.left;
        }
        
        pointer = stack.pop();
        res.push(pointer.val);
        pointer = pointer.right;
    }
    return res;
};