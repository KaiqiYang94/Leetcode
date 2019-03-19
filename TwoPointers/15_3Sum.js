// Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

// Note:

// The solution set must not contain duplicate triplets.

// Example:

// Given array nums = [-1, 0, 1, 2, -1, -4],

// A solution set is:
// [
//   [-1, 0, 1],
//   [-1, -1, 2]
// ]


// solution: a + b + c = 0
// sort the array, then for each of the values in the array find two element so that they added up equals to 0
// in each iteration, start from the left and right side of the rest of the array
// if the sum is larger than 0, decrease the right pointer to get a lower value
// if the sum is less than 0, increase the left pointer to get a higher value
// if the sum is same as 0, decrease the right and increase the left together (skipping through the same values.)
// O(N^2)


/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function(nums) {
    nums = nums.sort(function(a, b){return a -b});
    var res = [];
    for(var i = 0; i < nums.length; i ++){
        // dedup the sum target
        if(i > 0 && nums[i] === nums[i - 1] ) continue;
        
        j = i + 1;              // start from left
        k = nums.length - 1;    // start from right
        
        // while the two pointer haven't met
        while(j < k)
        {
            var sum = nums[i] + nums[j] + nums[k];
            if(sum === 0){
                res.push([nums[i], nums[j], nums[k]]);
                
                // jump through all the same value
                while(nums[j] === nums[j + 1]) j ++;
                j ++;
                
                // jump through all the same value
                while(nums[k] === nums[k - 1]) k --;
                k --;
            }else if(sum <  0){
                j ++;
            }else{
                k --;
            }            
        }
    }
    return res;
};