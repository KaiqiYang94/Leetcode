public class Solution {
    public int[,] dp;
    public int MinSteps(int n) 
    {
        dp =  new int[n + 1, n + 1];
        return n == 1? 0 : MinStepsUnder(1, 1, n) + 1;
    }
    
    public int MinStepsUnder(int onPage, int onPaste, int goal)
    {
        if(dp[onPage, onPaste] != 0)
        {
            return dp[onPage, onPaste];
        }
        if(onPage == goal)
        {
            return 0;
        }
        if(onPage + onPaste == goal)
        {
            dp[onPage, onPaste] = 1;
            return 1;
        }
        else if(onPage + onPaste > goal)
        {
            dp[onPage, onPaste] = 10000;
            return 10000;
        }
        
        var copyStep = onPage == onPaste? 10000000: MinStepsUnder(onPage, onPage, goal) + 1;
        var pasteStep =  MinStepsUnder(onPage + onPaste, onPaste, goal) + 1;
        
        dp[onPage, onPaste] = Math.Min(copyStep, pasteStep);
        return dp[onPage, onPaste];
    }
}