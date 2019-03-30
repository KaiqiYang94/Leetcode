/**
 * @param {number[]} piles
 * @return {boolean}
 */

var stoneGame = function(piles) {
   
    var matrix = piles.map(item => item);
    
    for(var length = 1; length < matrix.length; length ++ ){
        for(var start = 0; start < matrix.length && start + length < matrix.length ; start ++){
            var end = start + length;
            
            var takeFirst = piles[start] - matrix[start + 1];
            var takeLast = piles[end] - matrix[start];
            
            matrix[start] = takeFirst > takeLast? takeFirst : takeLast;

        }
    }
    return matrix[0] > 0;    
};
