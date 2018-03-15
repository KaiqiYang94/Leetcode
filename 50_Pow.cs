//ToOffer_11
// Implement pow(x, n).

// Example 1:

// Input: 2.00000, 10
// Output: 1024.00000
// Example 2:

// Input: 2.10000, 3
// Output: 9.26100

public class Solution {
    public double MyPow(double x, int n) {
        double result = 1;
        long exp = Math.Abs((long)n); // here !!!!
        while(exp > 0)
        {
            if(exp % 2 == 1)
            {
                result *= x;
            }
            exp >>= 1;
            x *= x;
        }
        return n >= 0? result : 1/result;            
    }
}