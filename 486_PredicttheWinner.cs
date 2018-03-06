public class Solution {
    public int[,] Result;
    public int[] input;
    public bool PredictTheWinner(int[] nums) {
        Result = new int[nums.Count(), nums.Count()];
        input = nums;
        
        
        return GetHighestScore(0, nums.Count() -1) >= 0;
    }
    
    public int GetHighestScore(int start, int end)
    {
        if(Result[start, end] != 0)
        {
            return Result[start, end];
        }
        if(start == end)
        {
            Result[start, end] = input[start];
            return Result[start, end];
        }
        int GotStart = input[start] - GetHighestScore(start + 1, end) ;        
        int GotEnd = input[end]- GetHighestScore(start, end -1);
        
        int result = Math.Max(GotStart, GotEnd);
        Result[start, end] = result;
        return result;
    }
}