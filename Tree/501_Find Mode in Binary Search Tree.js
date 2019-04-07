// Given a binary search tree (BST) with duplicates, find all the mode(s) (the most frequently occurred element) in the given BST.

// Assume a BST is defined as follows:

// The left subtree of a node contains only nodes with keys less than or equal to the node's key.
// The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
// Both the left and right subtrees must also be binary search trees.
 

// For example:
// Given BST [1,null,2,2],

//    1
//     \
//      2
//     /
//    2
 

// return [2].

// Note: If a tree has more than one mode, you can return them in any order.

// Follow up: Could you do that without using any extra space? (Assume that the implicit stack space incurred due to recursion does not count).


// solution:
//          In case of binary search trees (BST), Inorder traversal gives nodes in non-decreasing order. So that the same numbers will be next to each other !!!!

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
var maxCount;
var currentValue;
var currentCount;
var res;

var findMode = function(root) {
    maxCount = 0;
    currentValue;
    currentCount = 0;
    res = [];
    
    inorder(root);
    return res;
};


var inorder = function(root){
    if(root === null){return;}
    inorder(root.left)
    recordValue(root.val)
    inorder(root.right)
}

var recordValue = function(val){
    if(currentValue != val){
        currentValue = val;
        currentCount = 0;
    }
    currentCount ++;

    if(currentCount === maxCount){
        res.push(val);
    }
    if(currentCount > maxCount){
        res = [];
        res.push(val);
        maxCount = currentCount;
    }
}