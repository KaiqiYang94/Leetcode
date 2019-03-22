// ToOffer_12
// Given a collection of distinct numbers, return all possible permutations.

// For example,
// [1,2,3] have the following permutations:
// [
//   [1,2,3],
//   [1,3,2],
//   [2,1,3],
//   [2,3,1],
//   [3,1,2],
//   [3,2,1]
// ]


using System.Linq;

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        return ReturnPermute(nums.ToList());
    }
    
    public IList<IList<int>> ReturnPermute(IList<int> nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        
        if(nums.Count() == 1)
        {
            result.Add(new List<int>(){nums[0]});
        }
        
        foreach(int num in nums)
        {
            var subPermute = ReturnPermute(nums.Where(i => i != num).ToList()).ToList();
            foreach(var per in subPermute)
            {
                per.Insert(0, num);
            }
            result.AddRange(subPermute);
        }
        return result;
    }
}