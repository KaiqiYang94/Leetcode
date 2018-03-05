public class Solution {
    public int[] CountBits(int num) {
        var res = new int[num + 1];
        var offset = 1;
        for(int i = 1; i <= num; i ++)
        {
            offset = i == offset * 2? i: offset; 
            res[i] = res[i - offset] + 1;
        }
        return res;
    }
}