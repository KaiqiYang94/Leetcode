public class Solution {
    int d1;
    int d2;
    
    public bool isOkayForTheDiagnal(int[,] matrix, int row, int col)
    {
        int toRight = col;
        int toDown = row;
        int recordVal = matrix[toDown, toRight];
        for(; toDown <= d1 && toRight <= d2;  )
        {
            if(recordVal != matrix[toDown, toRight])
            {
                return false;
            }
            toDown ++ ;
            toRight ++;
        }
        return true;
    }
    
    public bool IsToeplitzMatrix(int[,] matrix) {
        d1 = matrix.GetUpperBound(0);
        d2 = matrix.GetUpperBound(1);
        
        for(int col = 0; col <= d2; col ++)
        {
            if(!isOkayForTheDiagnal(matrix, 0, col))
            {
                return false;
            }
        }
        
        for(int row = 1; row <= d1; row ++)
        {
            if(!isOkayForTheDiagnal(matrix, row, 0))
            {
                return false;
            }
        }
        

        return true;
    }
}