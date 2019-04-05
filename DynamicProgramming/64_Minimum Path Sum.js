// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

// Note: You can only move either down or right at any point in time.

// Example:

// Input:
// [
//   [1,3,1],
//   [1,5,1],
//   [4,2,1]
// ]
// Output: 7
// Explanation: Because the path 1→3→1→1→1 minimizes the sum.


// an inplace method

/**
 * @param {number[][]} grid
 * @return {number}
 */
var minPathSum = function(grid) {
    for(var i = grid.length - 1; i >= 0; i-- ){
    for(var j = (grid[0]).length - 1; j >= 0; j-- ){
        if(i === grid.length - 1 && j === (grid[0]).length - 1){
            continue;
        }
        var moveDown = i + 1 < grid.length? grid[i + 1][j] : Number.MAX_SAFE_INTEGER;
        var moveRight= j + 1 < (grid[0]).length? grid[i][j + 1] : Number.MAX_SAFE_INTEGER;
        grid[i][j] += Math.min(moveDown, moveRight);
    }
}
return grid[0][0];
};