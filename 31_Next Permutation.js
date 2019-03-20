// Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.

// If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).

// The replacement must be in-place and use only constant extra memory.

// Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.

// 1,2,3 → 1,3,2
// 3,2,1 → 1,2,3
// 1,1,5 → 1,5,1

// The whole idea:
// find the number where needs to be switched/swapped/increased, where nums[i + 1] > nums[i]
// and then, from the right part of the array, find the next larger number, which is the one should be switched to the left place
//          by find the number starting from the right side, (if there are many same numbers, we are switching to the last one, so that the right part of the array is always decreasing)
//          reverse the right part of the array.



/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var switchItem = function(nums, a, b){
    var c = nums[b];
    nums[b] = nums[a];
    nums[a] = c;
};

var nextPermutation = function(nums) {
    if(nums.length <= 1) return nums;
    var indexToSwitch = nums.length - 2;

    ///////////// find the place to switch, don't need to care about anything above
    while(indexToSwitch >= 0 && nums[indexToSwitch] >= nums[indexToSwitch + 1]){
        indexToSwitch --;
    }
    console.log(indexToSwitch)

    ///////////// find the next larger number, and swtich to the left
    // if indexToSwitch is less than 0 that means the whole array is decreasing, so skip the next step
    var justLarger = 0;
    if(indexToSwitch >= 0){
        justLarger = indexToSwitch + 1;
        // find the next large number from the right of the array incase there are equal values in the array.
        for(var j = nums.length - 1 ; j > indexToSwitch; j--){
            if(nums[j] > nums[indexToSwitch]) {
                justLarger = j;
                break;
            }
        }
        
        switchItem(nums, justLarger, indexToSwitch);
    }
    console.log(justLarger)
    console.log(nums)

    ///////////// reverse the rest of the array
    var left, right;
    for(left = indexToSwitch + 1, right = nums.length -1; left < right; left ++, right --){
        switchItem(nums, left, right)
    }
        
    return nums;
};

