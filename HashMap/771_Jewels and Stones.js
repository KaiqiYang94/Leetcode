/**
 * @param {string} J
 * @param {string} S
 * @return {number}
 */
var numJewelsInStones = function(J, S) {
    var map ={}
    for(var i = 0; i < J.length; i ++){
        map[J[i]] = true;
    }
    
    var res = 0;
    for(var i = 0; i < S.length; i++){
        if(map[S[i]] === true){
            res ++;
        }
    }
    return res;
};