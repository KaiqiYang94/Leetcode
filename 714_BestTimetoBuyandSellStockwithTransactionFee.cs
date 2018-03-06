public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        if(prices == null || prices.Length == 0)
        {
            return 0;
        }
        
        int buy = - prices[0];
        int sell = 0;
        
        for(var i = 1; i < prices.Length; i ++)
        {
            buy = Math.Max(buy, sell - prices[i]);
            sell = Math.Max(sell, buy + prices[i] -fee );
        }
        return sell ;
    }
}