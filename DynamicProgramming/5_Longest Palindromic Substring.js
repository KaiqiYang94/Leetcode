// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

// Example 1:

// Input: "babad"
// Output: "bab"
// Note: "aba" is also a valid answer.
// Example 2:

// Input: "cbbd"
// Output: "bb"


/**
 * @param {string} s
 * @return {string}
 * The recursion approach got Time Limit Exceeded 
 */
let longestPalindrome = function(s) {
    if(s === null || s === undefined || s.length == 1) return s;
    
    let i = 0; 
    let j = s.length -1;
    
    if(s[i] === s[j] && isPalinedromic(s))
    {
        return s;
    }
    
    let right = longestPalindrome(s.substr(0, s.length -1))
    
    let left = longestPalindrome(s.substr(1, s.length -1))
    
    return left.length >= right.length? left : right;
    
};


let isPalinedromic = function(s) {
    
    if(s === null || s === undefined) return false;
    
    for(let i = 0, j = s.length -1; i <= j ; ){
        if(s[i] !== s[j])
        {
            return false;
        }            
        i ++;
        j --;
    }
    return true;
}


let resultArray = null;











// recursion







    

// "babad"
// "cbbd"
// "aa"
// "a"
// "qwere"


/**
 * @param {string} s
 * @return {string}
 */

let longestPalindrome = function(s) {

    
    if(s === null || s === undefined || s.length <= 1) return s;
    
    // two dimension array
    let resultArray = new Array(s.length + 1);
    for (let i = 0; i < s.length + 1; i++) {
       resultArray[i] = new Array(s.length + 1);
    }

    
    for (let len = 0; len <= s.length; len++) {
        for (let start = 0; start <= s.length - len; start++) {
            // always point to the next available slot
            let end = start + len; 

            if(len <= 1 || (s[start] === s[end -1] && resultArray[start + 1][end -1].length == len -2))
            {
                resultArray[start][end] = s.substring(start, end);
                continue;
            }
            
            resultArray[start][end] = resultArray[start + 1][end].length > resultArray[start][end -1].length
                                    ? resultArray[start + 1][end] : resultArray[start][end -1];
        }  
    }
    
    return resultArray[0][s.length];    
};