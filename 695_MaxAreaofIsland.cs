// Given a non-empty 2D array grid of 0's and 1's, an island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

// Find the maximum area of an island in the given 2D array. (If there is no island, the maximum area is 0.)

// Example 1:
// [[0,0,1,0,0,0,0,1,0,0,0,0,0],
//  [0,0,0,0,0,0,0,1,1,1,0,0,0],
//  [0,1,1,0,1,0,0,0,0,0,0,0,0],
//  [0,1,0,0,1,1,0,0,1,0,1,0,0],
//  [0,1,0,0,1,1,0,0,1,1,1,0,0],
//  [0,0,0,0,0,0,0,0,0,0,1,0,0],
//  [0,0,0,0,0,0,0,1,1,1,0,0,0],
//  [0,0,0,0,0,0,0,1,1,0,0,0,0]]
// Given the above grid, return 6. Note the answer is not 11, because the island must be connected 4-directionally.
// Example 2:
// [[0,0,0,0,0,0,0,0]]
// Given the above grid, return 0.
// Note: The length of each dimension in the given grid does not exceed 50.

public class Solution {
    public int d1;
    public int d2;

    public int MaxAreaOfIsland(int[,] grid) {
        int maxArea = 0;
        d1 = grid.GetLength(0);
        d2 = grid.GetLength(1);

        for (int x = 0; x < d1; x += 1) {
            for (int y = 0; y < d2; y += 1) {
                if(grid[x, y] == 1)
                {
                    var currentArea = CalTheArea(grid, x, y);
                    maxArea = currentArea > maxArea? currentArea: maxArea;
                }
            }
        }
        return maxArea;
    }
    
    public int CalTheArea(int[,] grid, int x, int y)
    {
        if(x >= d1 || y >=d2 || x < 0 || y < 0 || grid[x, y] <= 0)
        {
            return 0;
        }
        if(grid[x, y] == 1)
        {
            grid[x, y] =  0; // mark the place to prevent re-calculation
            int area = 1 + CalTheArea(grid, x, y + 1) 
                + CalTheArea(grid, x, y - 1) 
                + CalTheArea(grid, x + 1, y) 
                + CalTheArea(grid, x - 1, y);
            
            return area;
        }
        return 0;
    }
}