// Given a non-empty array of integers, return the third maximum number in this array. If it does not exist, return the maximum number. The time complexity must be in O(n).

// Example 1:
// Input: [3, 2, 1]

// Output: 1

// Explanation: The third maximum is 1.
// Example 2:
// Input: [1, 2]

// Output: 2

// Explanation: The third maximum does not exist, so the maximum (2) is returned instead.
// Example 3:
// Input: [2, 2, 3, 1]

// Output: 1

// Explanation: Note that the third maximum here means the third maximum distinct number.
// Both numbers with value 2 are both considered as second maximum.


/**
 * @param {number[]} nums
 * @return {number}
 */
var thirdMax = function(nums) {
    var stack = [];
    var nthNumber = 3;
    stack.push(nums[0]);
    for(var i = 1; i < nums.length; i++){
        if(stack.indexOf(nums[i]) != -1) continue;
        if(stack.length < nthNumber || stack[0] < nums[i]){
            stack.push(nums[i]);
            stack.sort((a, b) => a - b);
            if(stack.length > nthNumber){
                stack.shift();
            }
        }
    }
    return stack.length == nthNumber? stack[0] : stack[stack.length - 1];
};