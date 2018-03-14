// Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.

// For example,
// Given n = 3,

// You should return the following matrix:
// [
//  [ 1, 2, 3 ],
//  [ 8, 9, 4 ],
//  [ 7, 6, 5 ]
// ]

public class Solution {
    public int[,] directions = new int[,]{{0,1},{1,0},{0,-1},{-1,0}};
    public int row;
    public int[,] GenerateMatrix(int n) {
        int [,] res = new int[n, n];
        row = n;
        SprialOrderMatrix(res, 0, 0, 0, 1);
        return res;
    }
    
    public bool SprialOrderMatrix(int[,] matrix, int x, int y, int direction, int num)
    {
        if(x >= row || x < 0 || y >= row || y < 0 || matrix[x, y] != 0)
        {
            return false;
        }
        // mark the current cell
        matrix[x, y] = num;
        
        // keep the same direction
        bool filledCells = SprialOrderMatrix(matrix, x + directions[direction, 0], y + directions[direction, 1], direction, num + 1);
        
        // or change to the next direction
        if(!filledCells)
        {
            direction = (direction + 1) % 4;
            SprialOrderMatrix(matrix, x + directions[direction, 0], y + directions[direction, 1], direction, num + 1);
        }
        return true;
    }
}
