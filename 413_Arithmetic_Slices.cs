public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        int currentNum = 0 ;
        int currentArithmetic = 0;
        for(int i = 0; i < A.Length - 2; i ++)
        {
            if(A[i] - A[i+1] == A[i +1] - A[i+2])
            {
                currentNum ++;
            }
            else
            {
                currentArithmetic += (currentNum + 1)*currentNum / 2;
                currentNum = 0;
            }
        }
        
        currentArithmetic += (currentNum + 1)*currentNum / 2;
        return currentArithmetic;
    }
}