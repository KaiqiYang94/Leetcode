// A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

// The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

// How many possible unique paths are there?


// Above is a 7 x 3 grid. How many possible unique paths are there?

// Note: m and n will be at most 100.

// Example 1:

// Input: m = 3, n = 2
// Output: 3
// Explanation:
// From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
// 1. Right -> Right -> Down
// 2. Right -> Down -> Right
// 3. Down -> Right -> Right
// Example 2:

// Input: m = 7, n = 3
// Output: 28



/**
 * @param {number} m
 * @param {number} n
 * @return {number}
 */
var uniquePaths = function(m, n) {
    var total = m + n -2;
    var downStep = n - 1;
    
    var res = 1;
    var factorize_downStep = 1;
    var factorize_total_downStep = 1;
    for(var i = 1; i <= total; i++){
        res *= i;
        if(i === downStep)          factorize_downStep = res;
        if(i === total - downStep)  factorize_total_downStep = res;
    }

    return res/(factorize_downStep * factorize_total_downStep);
};
