public class Solution {
    public int HammingDistance(int x, int y) {
        int diffs = 0;
        
        int maxNum = x > y? x : y;
        
        for(int i = 30; i >= 0; i --)
        {
            int currentNum = (int)Math.Pow(2, i);
            if(maxNum < currentNum) 
            {
                continue;
            }
            int deivdex = x /  currentNum;
            int deivdey = y /  currentNum;
            
            x = x - deivdex * currentNum;        
            y = y - deivdey * currentNum;
            
            if(deivdex != deivdey)
            {
                diffs ++;
            }
        }
        return diffs;
    }
}