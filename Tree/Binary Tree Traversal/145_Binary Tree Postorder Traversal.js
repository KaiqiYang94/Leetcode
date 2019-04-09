// Given a binary tree, return the postorder traversal of its nodes' values.

// Example:

// Input: [1,null,2,3]
//    1
//     \
//      2
//     /
//    3

// Output: [3,2,1]
// Follow up: Recursive solution is trivial, could you do it iteratively?


// for Preorder:
//          check parent
//          push parent          
//          go left until no left
//          stack pop
//          go right
// in short: parent, left, right
// then for post order: parent, right, left. And then reverse it.

//          What's in stack? the elements who's right branch needs to be searched. 
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
var postorderTraversal = function(root) {
    var res = [];
    var stack = [];
    var pointer = root;
    while(pointer != null || stack.length != 0){
        while(pointer != null){
            stack.push(pointer)
            res.unshift(pointer.val);
            pointer = pointer.right;
        }
        pointer = stack.pop().left;
    }
    return res;
};