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

/**
 * @param {number[]} A
 * @return {number}
 */
var sumSubarrayMins = function(A) {
    // needs to be a increasing array
    // 1 2 4, 3 <-
    // 1 2 3
    // 4's next less is 3, when 4 is poped
    var originLengh = A.length;

    // push 0 which is less than any number would clean out the stack.
    A.push(0);
    var resArr = Array(originLengh);
    var nextLessStack = [];
    var sum = 0;
    for(var i = 0; i < A.length; i ++){     
        //console.log(nextLessStack)
        while(nextLessStack.length != 0 && A[i] < A[nextLessStack[nextLessStack.length - 1]]){
            var index = nextLessStack.pop();
            resArr[index] = i - index;
        }
        nextLessStack.push(i);
    }
    nextLessStack = []
    //console.log(resArr)
    A.pop();
    A.unshift(0);
    var res = 0;
    for(var i = A.length - 1; i >= 0; i --){        
        // be careful about the "<=" her and the "<"
        // needs to cater
        while(nextLessStack.length != 0 && A[i] <= A[nextLessStack[nextLessStack.length - 1]]){
            var index = nextLessStack.pop();
            res += resArr[index - 1] * (index - i) * A[index];
            res %= Math.pow(10, 9) + 7
        }
        nextLessStack.push(i);
    }
    //console.log(resArr)
    return res;
};

//   3 1 2 4
// 3 3 1 1 1
// 1   1 1 1
// 2     2 2
// 4       4

// one less and one less and equal to 
// catering for this case
// when there are same numbers,
// cell with 11 in the chart is the overlapping area
// where should be calculated only once.
//   3 1 2  1
// 3 3 1 1 11
// 1   1 1 11
// 2     2  1
// 4        4
