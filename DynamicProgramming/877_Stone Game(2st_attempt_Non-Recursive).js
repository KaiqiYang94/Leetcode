/**
 * @param {number[]} piles
 * @return {boolean}
 */

var stoneGame = function(piles) {
   
    var matrix = Array(piles.length);
    for(var i = 0; i < matrix.length; i++){
        matrix[i] = Array(piles.length).fill(undefined);
    }

    for(var length = 0; length < matrix.length; length ++ ){
        for(var start = 0; start < matrix.length && start + length < matrix.length ; start ++){
            var end = start + length;
            
            if(start === end){
                matrix[start][end] = piles[start];
                continue;
            }
            
            var takeFirst = piles[start] - matrix[start + 1][end];
            var takeLast = piles[end] - matrix[start][end - 1];
            
            matrix[start][end] = takeFirst > takeLast? takeFirst : takeLast;
        }
    }
    
    return matrix[0][piles.length -1] > 0;    
};
