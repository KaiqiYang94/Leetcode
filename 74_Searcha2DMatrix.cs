// ToOffer_3
// Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

// Integers in each row are sorted from left to right.
// The first integer of each row is greater than the last integer of the previous row.
// For example,

// Consider the following matrix:

// [
//   [1,   3,  5,  7],
//   [10, 11, 16, 20],
//   [23, 30, 34, 50]
// ]
// Given target = 3, return true.

public class Solution {
    public int d1;
    public int d2;
    public bool SearchMatrix(int[,] matrix, int target) {
        d1 = matrix.GetLength(0);
        d2 = matrix.GetLength(1);
        
        if(d1 == 0 || d2 == 0 || matrix == null)
        {
            return false;
        }
        return FindInMatrix(matrix, target, 0, d2 - 1);
    }
    
    public bool FindInMatrix(int[,] matrix, int target, int x, int y)
    {
        if(x >=0 && x < d1 && y >= 0 && y < d2)
        {
            if(matrix[x, y] == target)
            {
                return true;
            }
            if(matrix[x, y] < target )
            {
                return FindInMatrix(matrix, target, x + 1, y);
            }else
            {
                return FindInMatrix(matrix, target, x , y - 1);
            }
        }
        return false;
    }
}