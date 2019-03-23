// Given a 2D board and a word, find if the word exists in the grid.

// The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

// Example:

// board =
// [
//   ['A','B','C','E'],
//   ['S','F','C','S'],
//   ['A','D','E','E']
// ]

// Given word = "ABCCED", return true.
// Given word = "SEE", return true.
// Given word = "ABCB", return false.


/**
 * @param {character[][]} board
 * @param {string} word
 * @return {boolean}
 */
var existAtHere = function(markBoard, board, word, i, j) {
    var mapKey = i.toString() + "_" +  j.toString();
    if(markBoard[mapKey] === true){
        return false;
    }
    if(board[i][j] === word[0]){
        if(word.length === 1){return true;}
        markBoard[mapKey] = true;
        var nextTarget = word.slice(1);
        var res = false;
        res = res || (j + 1 < board[0].length && existAtHere(markBoard, board, nextTarget, i, j + 1));
        if(res){
            markBoard[mapKey] = false;
            return res;
        }
        res = res || (j - 1 >= 0 && existAtHere(markBoard, board, nextTarget, i, j - 1));
        if(res){
            markBoard[mapKey] = false;
            return res;
        }
        res = res || (i + 1 < board.length && existAtHere(markBoard, board, nextTarget, i + 1, j));
        if(res){
            markBoard[mapKey] = false;
            return res;
        }
        res = res || (i - 1 >= 0 && existAtHere(markBoard, board, nextTarget, i - 1, j));
        
        markBoard[mapKey] = false;
        return res;
    }
    return false;
};

var exist = function(board, word) {
    var markBoard = new Object();
    for(var i = 0; i < board.length; i++){
        for(var j = 0; j < board[0].length; j++){
            var exists = existAtHere(markBoard,board, word, i, j);
            if(exists){
                return true;
            }
        }   
    }
    return false;
};