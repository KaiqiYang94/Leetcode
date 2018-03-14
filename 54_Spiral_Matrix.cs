// ToOffer_20
// Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

// For example,
// Given the following matrix:

// [
//  [ 1, 2, 3 ],
//  [ 4, 5, 6 ],
//  [ 7, 8, 9 ]
// ]
// You should return [1,2,3,6,9,8,7,4,5].

public class Solution {
    public int d1;
    public int d2;
    public static int identifier = int.MinValue;
    public int[,] directions = new int[,]{{0,1},{1,0},{0,-1},{-1,0}};
    
    public IList<int> SpiralOrder(int[,] matrix) {
        d1 = matrix.GetLength(0);        
        d2 = matrix.GetLength(1);
        return SprialOrderMatrix(matrix, 0, 0, 0) ?? new List<int>();
    }
    
    public IList<int> SprialOrderMatrix(int[,] matrix, int x, int y, int direction)
    {
        if(x >= d1 || x < 0 || y >= d2 || y < 0 || matrix[x, y] == identifier)
        {
            return null;
        }
        // mark the current cell
        IList<int> res = new List<int>();
        res.Add(matrix[x, y]);
        matrix[x, y] = identifier;
        
        // keep the same direction
        IList<int> RestMatrix = SprialOrderMatrix(matrix, x + directions[direction, 0], y + directions[direction, 1], direction);
        
        // or change to the next direction
        if(RestMatrix == null)
        {
            direction = (direction + 1) % 4;
            RestMatrix = SprialOrderMatrix(matrix, x + directions[direction, 0], y + directions[direction, 1], direction);
        }
        return res.Concat(RestMatrix ?? new List<int>()).ToList();
    }
}