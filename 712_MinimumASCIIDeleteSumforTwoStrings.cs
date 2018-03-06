public class Solution {
   
    public int MinimumDeleteSum(string s1, string s2) {
        int [,] resTable = new int[s1.Length + 1 , s2.Length +1 ];
        
        resTable[0, 0] = 0;
        for(int i = 1; i <= s1.Length; i ++)
        {
            resTable[i, 0] = resTable[i -1, 0] + (int)s1[i - 1]; 
        }
        for(int i = 1; i <= s2.Length; i ++)
        {
            resTable[0, i] = resTable[0, i -1] + (int)s2[i - 1];
        }
        
        for(int i = 1; i <= s1.Length; i ++)
        {
            for(int j = 1; j <= s2.Length; j ++)
            {
                if(s1[i-1] == s2[j-1])
                {
                    resTable[i, j] = resTable[i -1, j -1];
                }
                else
                {
                    resTable[i, j] = Math.Min(resTable[i - 1, j] + (int)s1[i-1], resTable[i, j - 1] + (int)s2[j-1]);
                }
            }
        }
        
        return resTable[s1.Length , s2.Length ];
    }
}