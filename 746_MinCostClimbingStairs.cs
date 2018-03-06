public class Solution {
    public int[] costArr;
    
    public int MinCostClimbingStairs(int[] cost) {
        var c1 = 0;
        var c2 = 0;
        for(int i = cost.Length -1; i >=0 ; i--)
        {
            var temp = cost[i] + Math.Min(c1, c2);            
            c2 = c1;
            c1 = temp;
        }
        return Math.Min(c1, c2);
    }
    

}