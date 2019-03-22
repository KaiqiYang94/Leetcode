/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var permute = function(nums) {
    var res = [];
    if(nums.length === 1){
        var temp = [];
        temp.push(nums)
        return temp;
    }
    
    for(var i = 0; i < nums.length; i++){
        var filtered = nums.filter(function(value, index, arr){return value != nums[i];})
        var subPermute = permute(filtered);
        
        for(var j = 0; j < subPermute.length; j++){
            (subPermute[j]).push(nums[i])
            res.push(subPermute[j])
        }
        
    }
    return res;
};