// Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?

// Example:

// Input: 3
// Output: 5
// Explanation:
// Given n = 3, there are a total of 5 unique BST's:

//    1         3     3      2      1
//     \       /     /      / \      \
//      3     2     1      1   3      2
//     /     /       \                 \
//    2     1         2                 3

// computed[i] means a sub problem
// 
// computed[N] = computed[0] * computed[N-1] + computed[1] * computed[N-2] + ...  +computed[N-1] * computed[0]
// computed[j] * computed[i-1-j] means the number of unique trees when i is the root tree

/**
 * @param {number} n
 * @return {number}
 */
var numTrees = function(n) {
    var computed = Array(n + 1);
    computed[0] = 1;
    computed[1] = 1;
    for(var i = 2; i <= n; i ++){
        var res = 0;
        for(var j = 0; j < i; j ++){
            res += computed[j] * computed[i-1-j];
        }    
        computed[i] = res;
    }
    return computed[n];
};