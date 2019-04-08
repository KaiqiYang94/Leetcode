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


// Main idea
//              A pointer going through the tree. Left and the right, also need to record the parent pointer for each node to find the way back.
//              Also needs to keep records of whether an item is checked or not.    

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
    
    var pointer = root;
    
    while(pointer != undefined){
        if(pointer.left != null && pointer.left.checked != true){
            pointer.left.parent = pointer;
            pointer = pointer.left;
            continue;
        }
        if(pointer.checked != true){
            res.push(pointer.val);
            pointer.checked = true;
        }
        
        if(pointer.right != null && pointer.right.checked != true){
            pointer.right.parent = pointer;
            pointer = pointer.right;  
            continue;
        }
        if(pointer.parent === undefined) break;
        pointer = pointer.parent;
    }
    return res;
};