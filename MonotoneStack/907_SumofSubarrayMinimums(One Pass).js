// Given an array of integers A, find the sum of min(B), where B ranges over every (contiguous) subarray of A.

// Since the answer may be large, return the answer modulo 10^9 + 7.


// Example 1:

// Input: [3,1,2,4]
// Output: 17
// Explanation: Subarrays are [3], [1], [2], [4], [3,1], [1,2], [2,4], [3,1,2], [1,2,4], [3,1,2,4]. 
// Minimums are 3, 1, 2, 4, 1, 1, 2, 1, 1, 1.  Sum is 17.
 

// Note:

// 1 <= A.length <= 30000
// 1 <= A[i] <= 30000

// Solution: maintain a increase stack, because we are trying to find the next less item. 
// when an item A is poped, the comming in item B is A's next less item. 
//      Because if there is an item A > C > B, A will be poped already)
// when an item A is pushed, the item B right before item A is A's previous less item.
//      Because if there is an item A < C < B, C will not be poped by A. 
//      If it was poped by something else e.g. D, then D must be less than B, then D should stay, which is the previous less item, which should be right before A
//      Or put it in another way, give A is the previous less item of B, need to approve A is right before B when B is in stack
//          so, given the assumption, between A and B the numbers must be larger than or equal to B, which means they are also larger than A
//          so, A will not be poped by those items, and if there are anything left when B is comming into the array, they will all be poped by B
//          in the case that there are equal items, they will not be poped, because the area should not be calcualted twice, (check 907 two pass)
//          

// [3, 1, 2, 4]
// 3    [3
// 1    [1      //when 3 is poped, 1 is 3's next less item,
// 2    [1 2    // when 
// 4    [1 2 4
/**
 * @param {number[]} A
 * @return {number}
 */
var sumSubarrayMins = function(A) {
    // add two boundaries, so the stack will be emptied as the end
    A.push(0);
    A.unshift(0);
    var resArr = Array(A.length);
    var nextLessStack = [];
    var res = 0;
    var MOD = Math.pow(10, 9) + 7;
    for(var i = 0; i < A.length; i ++){
        // equal items will not be poped, so the overlapping areas will only be calculated once.
        while(nextLessStack.length != 0 && A[i] < A[nextLessStack[nextLessStack.length - 1]]){
            var index = nextLessStack.pop();
            res += resArr[index] * (i - index) * A[index];
            res = res >= MOD ? res % MOD : res;
        }
        resArr[i] =  i - nextLessStack[nextLessStack.length - 1]
        nextLessStack.push(i);
    }
    //console.log(nextLessStack)
    return res;
};