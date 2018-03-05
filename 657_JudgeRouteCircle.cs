public class Solution {
    public bool JudgeCircle(string moves) {
        int moveH = 0;
        int moveV = 0;
        
        foreach(var move in moves)
        {
            if(move == 'R')
            {
                moveH ++;
            }
            else if(move == 'L')
            {
                moveH --;
            }
            else if(move == 'U')
            {
                moveV ++;
            }
            else if(move == 'D')
            {
                moveV --;
            }
            
        }
        return (moveH == 0 && moveV ==0);
    }
}