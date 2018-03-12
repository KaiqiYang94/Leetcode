// Given two integers n and k, you need to construct a list which contains n different positive integers ranging from 1 to n and obeys the following requirement: 
// Suppose this list is [a1, a2, a3, ... , an], then the list [|a1 - a2|, |a2 - a3|, |a3 - a4|, ... , |an-1 - an|] has exactly k distinct integers.

// If there are multiple answers, print any of them.

// Example 1:
// Input: n = 3, k = 1
// Output: [1, 2, 3]
// Explanation: The [1, 2, 3] has three different positive integers ranging from 1 to 3, and the [1, 1] has exactly 1 distinct integer: 1.
// Example 2:
// Input: n = 3, k = 2
// Output: [1, 3, 2]
// Explanation: The [1, 3, 2] has three different positive integers ranging from 1 to 3, and the [2, 1] has exactly 2 distinct integers: 1 and 2.
// Note:
// The n and k are in the range 1 <= k < n <= 10^4.


// Main idea: using a "wave"
// Found a pattern
//      (n = 6, k = 3) => 1, (+1) 2,(+1) 3,(+3)     6,(-2)      4,(+1)      5
//                                              index: n - k, wave start from here.
// Using the wave will make sure there are enough number of diffs
// and also the number is unique and within the boundaries


public class Solution {
    public int[] ConstructArray(int n, int k) {
        int[] res =  new int[n];
        int numFrom = 1;
        int nextDir = 1;
        res[0] = numFrom;
        for(int i = 1; i < n ; i ++ )
        {
            if(i == n - k)
            {
                res[i] = res[i - 1] + (nextDir * k--);
                nextDir *= -1;
            }
            else
            {
                res[i] = res[ i - 1 ] + 1;
            }
            
        }
        return res;
    }
}