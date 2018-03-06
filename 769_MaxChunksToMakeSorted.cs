public class Solution {
    
    public int MaxChunksToSorted(int[] arr) {
        int cnt = 0;
        int currentMax = 0;
        
        for(int i =0; i < arr.Count();)
        {
            cnt ++;
            if(arr[i] == i)
            {
                 i++;
                continue;
            }
            else
            {
                var toIndex = FindChunckTill(i, arr[i], arr);
                i = toIndex + 1;
            }
        }
        return cnt;
    }
    
    // will execute when the left is larger than the right one.
    public int FindChunckTill(int left, int right, int [] arr)
    {
        int maxVal = arr[left];
        int minVal = arr[right];
        
        int prevRight = right;
        while(true)
        {
            for(int i = left; i <= right; i++)
            {
                if(arr[i] < minVal)
                {
                    minVal = arr[i];
                }
                if(arr[i] > maxVal)
                {
                    maxVal = arr[i];
                }
            }
            right = maxVal;
            if(right == prevRight)
            {
                break;
            }
            else
            {
                prevRight = right;
            }
        }
        return right;   
    }
}