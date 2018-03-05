public class Solution {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        var numsR = nums.GetLength(0);        
        var numsC = nums.GetLength(1);

        if(r * c != numsR* numsC)
        {
            return nums;
        }
        
        var newMatrix = new int[r, c];
        var totalCnt = numsR * numsC;
        for(int i = 0; i < totalCnt; i ++)
        {
            newMatrix[ i/c , i%c] = nums[ i/numsC , i%numsC];
        }
        return newMatrix;
    }
}