public class Solution {
    public int CountSubstrings(string s) {
        
        var insertedSB = new StringBuilder();
        //insertedSB.Append("@");        
        insertedSB.Append("#");

        for(int i =0; i < s.Length; i ++)
        {
            insertedSB.Append(s[i]).Append("#");
        }
        //insertedSB.Append("$");

        var insertedS = insertedSB.ToString();
        
        var maxCenter = 0;
        var maxRight = 0;
        var maxPstrArr = new int[insertedS.Length];
        for(int i =1; i < insertedS.Length-1; i ++)
        {
            // try to used the computed res from the other side of the pivot
            if(i < maxRight)
            {
                maxPstrArr[i] = Math.Min( maxRight - i, maxPstrArr[2 * maxCenter - i]);
            }
            
            // expand the longest string based on the res
            while((i + maxPstrArr[i] + 1 < insertedS.Length ) && (i - maxPstrArr[i] -1) >= 0 && 
                  insertedS[i + maxPstrArr[i] + 1] == insertedS[ i - maxPstrArr[i] -1])
            {
                maxPstrArr[i] ++;
            }
            
            // update longest palindromic string so far
            if(maxPstrArr[i] > maxRight)
            {
                maxRight = maxPstrArr[i];
                maxCenter = i;
            }
        }
        
        var resCnt = 0;
        foreach (var cnt in maxPstrArr)
        {
            resCnt += (cnt + 1) /2 ;
        }
        return resCnt;        
    }
}