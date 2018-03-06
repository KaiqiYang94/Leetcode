public class Solution {
    public int[,] dp;
    public int Sum;
    public int[] Numbers;
    public int FindTargetSumWays(int[] nums, int S) {
        Numbers = nums;
        Sum = S;
        dp = new int [nums.Count() + 10, 2001];
        
        
        return FindSumWay(0, 0);
    }
    
    public int FindSumWay(int i, int sum)
    {
        if(i == Numbers.Count())
        {
            if(sum == Sum)
            {
                return 1;
            }
            return 0;
        }
        if(dp[i, sum +1000]!= 0)
        {
            return dp[i, sum + 1000];
        }
        var temp1 = FindSumWay(i + 1, sum - Numbers[i]);
        var temp2 = FindSumWay(i + 1, sum + Numbers[i]);
        
        dp[i, sum + 1000] = temp1 + temp2;
        return dp[i, sum + 1000];
    }
}