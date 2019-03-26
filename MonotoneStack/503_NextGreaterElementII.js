// Given a circular array (the next element of the last element is the first element of the array), print the Next Greater Number for every element. The Next Greater Number of a number x is the first greater number to its traversing-order next in the array, which means you could search circularly to find its next greater number. If it doesn't exist, output -1 for this number.

// Example 1:
// Input: [1,2,1]
// Output: [2,-1,2]
// Explanation: The first 1's next greater number is 2; 
// The number 2 can't find next greater number; 
// The second 1's next greater number needs to search circularly, which is also 2.
// Note: The length of given array won't exceed 10000.



/**
 * @param {number[]} nums
 * @return {number[]}
 */
var nextGreaterElements = function(nums) {
    var stack = [];
    var result = Array(nums.length).fill(-1);   // the default value
    for(var i = 0; i < 2 * nums.length; i ++){
        var index = i % nums.length;
        // if the stack is not empty and the number coming in is larger than the stack top number, then pop
        // not equal here.
        while(stack.length != 0 && nums[index] > numsA[stack[stack.length -1]]){
            result[stack.pop()] = nums[index];
        }
        
        // only push to stack in the first iteration
        if(i === index){
            stack.push(index);    
        }        
    }
    return result;
};