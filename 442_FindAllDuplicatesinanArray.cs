public class Solution {
    public IList<int> FindDuplicates(int[] nums) {        
        List<int> dupps = new List<int>();
        for(int i = 0; i < nums.Length; i ++)
        {
            nums[Math.Abs(nums[i]) -1] =  - nums[Math.Abs(nums[i]) -1];
            if(nums[Math.Abs(nums[i]) -1] > 0)
             {
                 dupps.Add(Math.Abs(nums[i]));
             }
        }
        return dupps;
    }
}