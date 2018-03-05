public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        var sum = 0;
        for(int i = 0; i < nums.Count(); i += 2)
        {
            sum += nums[i];
        }
        return sum;
    }
}