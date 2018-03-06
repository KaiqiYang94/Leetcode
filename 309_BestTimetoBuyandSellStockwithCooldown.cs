public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length == 0)
        {
            return 0;
        }
        
        int buy = - prices[0];
        int sell = 0;
        
        int preBuy = 0;
        int preSell = 0;
        int prepreSell = 0;
        
        for(var i = 1; i < prices.Length; i ++)
        {
            preBuy = buy;
            prepreSell = preSell;
            preSell = sell;
            
            buy = Math.Max(preBuy, prepreSell - prices[i]);
            sell = Math.Max(sell, preBuy + prices[i] );
        }
        return  sell;
    }
}