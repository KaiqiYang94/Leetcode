public class Solution {
    public int FindLongestChain(int[,] pairs) {
         int n = pairs.GetLength(0);
        int[] dp = new int[pairs.Length];
        for(int i=0; i<n; i++)
        {
            dp[i] = 1;
        }
        #region Sorting the pairs array!!!
        TwoDArray[] temparray = new TwoDArray[n];
        for(int i=0; i<n; i++)
        {
            temparray[i] = new TwoDArray(new int[] { pairs[i, 0] , pairs[i, 1] });
        }
        Array.Sort(temparray);
        for (int i = 0; i < n; i++)
        {
            pairs[i, 0] = temparray[i].array[0];
            pairs[i, 1] = temparray[i].array[1];
        }
        #endregion
        
        int max = 1;
        for(int i =1; i < n; i ++)
        {
            for(int j = 0 ; j < i; j ++)
            {
                if(pairs[i,0] > pairs[j,1] && dp[i] <= dp[j])
                {
                    dp[i] = dp[j] + 1;
                    max = Math.Max(max, dp[i]);
                }
            }
        }
            
        
        return max;
    }
}


public class TwoDArray : IComparable<TwoDArray>
{
    public int[] array { get; set;}
    public TwoDArray(int[] intarray)
    {
        array = intarray;
    }
    public int CompareTo(TwoDArray twoDArray)
    {
        return array[0].CompareTo(twoDArray.array[0]);
    }
}
