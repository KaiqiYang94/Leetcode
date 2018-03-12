// Given a binary array, find the maximum number of consecutive 1s in this array.

// Example 1:
// Input: [1,1,0,1,1,1]
// Output: 3
// Explanation: The first two digits or the last three digits are consecutive 1s.
//     The maximum number of consecutive 1s is 3.
// Note:

// The input array will only contain 0 and 1.
// The length of input array is a positive integer and will not exceed 10,000
// Easy
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxNum = 0;
        int currentNum = 0;
        
        foreach(int num in nums)
        {
            if(num == 1)
            {
                currentNum ++;
            }
            else
            {    
                maxNum = currentNum > maxNum? currentNum : maxNum;
                currentNum = 0;
            }
        }
        maxNum = currentNum > maxNum? currentNum : maxNum;
        return maxNum;
    }
}