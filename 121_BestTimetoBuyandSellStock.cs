public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0){return 0;}
        
        int maxPro = 0;
        int min = 100000000;
        
        for(int i = 0; i < prices.Length; i ++)
        {
            min = Math.Min(min, prices[i]);
            maxPro = Math.Max(maxPro, prices[i] - min);
        }
        
        return maxPro;
    }
}