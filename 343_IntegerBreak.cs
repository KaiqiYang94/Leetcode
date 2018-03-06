public class Solution {
    public int IntegerBreak(int n) {
        int[] res = new int [n +1];
        for(int i = 0; i <= n; i ++)
        {
            res[i] = 1;
        }
        for(int i = 1; i <= n; i ++)
        {
            int maxProd = 1;
            for(int j = 1; j < i; j ++)
            {
                // This line is tricky, because res[x] is the product of (x)
                // didn't count for x
                int prod = Math.Max(res[j], j) * Math.Max(res[i- j], (i - j));
                
                if(prod > maxProd)
                {
                    maxProd = prod;
                }
            }
            res[i] = maxProd;
        }
        return res[n];
    }
}