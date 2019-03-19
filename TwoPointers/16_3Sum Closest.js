// Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. Return the sum of the three integers. You may assume that each input would have exactly one solution.

// Example:

// Given array nums = [-1, 2, 1, -4], and target = 1.

// The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).


// solution: check #15
// O(N^2)

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var threeSumClosest = function(nums, target) {
    nums = nums.sort(function(a, b){return a -b});

    var closest = 10000;
    for(var i = 0; i < nums.length; i ++){
        // dedup the sum target
        if(i > 0 && nums[i] === nums[i - 1] ) continue;
        
        j = i + 1;              // start from left
        k = nums.length - 1;    // start from right
        
        // while the two pointer haven't met
        while(j < k)
        {
            var sum = nums[i] + nums[j] + nums[k] - target;
            if(sum === 0){
                return target;
            }
            
            if(Math.abs(sum) < Math.abs(closest)){
                closest = sum;
            }
            
            if(sum <  0){
                j ++;
            }else{
                k --;
            }            
        }
    }
    return closest + target ;
};