Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:
```
Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
```
Example 2:

```
Input: "cbbd"
Output: "bb"
```


## Solution 1: DP The idea I was going for

Transition:

```
f(s, start, end) = 

    if (s.first == s.end && s.substring(start + 1, end -1) is palindromic)
    {
        return s;
    }

    if (s.first != s.end){
        return the longest one in f(s, start + 1, end) or f(s, start, end - 1).
    }
```

Termination:

`When s.len < 2, s is palindromic`

AC answer:

```js
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
                let res = {
                    start: start,
                    end: end,
                    length: len
                }
                resultArray[start][end] = res;
                continue;
            }
            
            resultArray[start][end] = resultArray[start + 1][end].length > resultArray[start][end -1].length
                                    ? resultArray[start + 1][end] : resultArray[start][end -1];
        }  
    }
    
    return s.substring(resultArray[0][s.length].start, resultArray[0][s.length].end);    
};
```

With a shitty performance!


Approach 3: Dynamic Programming

![](Dynamic%20Programming.png)

## Solution 2: Around Center

Same with O(N^2) time complexity, but with constant space

![](Around%20Center.png)

```js
/**
 * @param {string} s
 * @return {string}
 */

let maxLen = 0;
let maxStarts = 0;

let longestPalindrome = function(s) {
    maxLen = 0;
    maxStarts = 0;
    
    
    if(s.length < 2){
        return s;
    }
    
    for(let center = 0 ; center < s.length -1 ; center ++){
        extendThePStr(s, center, center);
        extendThePStr(s, center, center + 1);
    }
    return s.substring(maxStarts, maxStarts + maxLen)
};

let extendThePStr = function(s, left, right){
    while(left >=0 && right < s.length && s[left] === s[right]){
        left --;
        right ++;
    }
    
    let longestLen = (right - 1) - (left + 1) + 1
    
    if(maxLen < longestLen){
        maxLen = longestLen;
        maxStarts = left + 1;
    }
}
```

Above code beats 93%.

### Manacher's Algorithm
![](Manacher's%20Algorithm.png)
Pretty good explanation [here](https://www.hackerrank.com/topics/manachers-algorithm), Chinese version [here](https://www.hackerrank.com/topics/manachers-algorithm).