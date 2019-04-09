// Given a binary tree, return the preorder traversal of its nodes' values.

// Example:

// Input: [1,null,2,3]
//    1
//     \
//      2
//     /
//    3

// Output: [1,2,3]
// Follow up: Recursive solution is trivial, could you do it iteratively?

// for Preorder:
//          check parent
//          push parent          
//          go left until no left
//          stack pop
//          go right

//          What's in stack? the elements who's right branch haven't been searched. 
//          Pointer? the node that should be searched. It can be null, just to pick up the top one in stack

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
var preorderTraversal = function(root) {
    var res = [];
    var stack = [];
    var pointer = root;
    
    while(pointer != null || stack.length != 0){
        while(pointer != null){
            res.push(pointer.val);
            stack.push(pointer);
            pointer = pointer.left;
        }
        pointer = stack.pop().right;
    }
    return res;
};