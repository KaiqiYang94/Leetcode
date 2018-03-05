public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var list = new List<int>();
        
        for(int i = left ; i <= right ;i ++)
        {
            if(IsSelfDividingNum(i))
            {
                list.Add(i);
            }
        }
        return list;
    }
    
    public bool IsSelfDividingNum(int number)
    {
        var oldNum = number;
        while( number >= 10)
        {
            var left = number % 10;
            number /= 10;
            
            if(left == 0 || oldNum % left != 0)
            {
                return false;    
            }            
        }
        
        if(number == 0 || oldNum % number != 0)
        {
            return false;    
        }  
        
        return true;
    }
}