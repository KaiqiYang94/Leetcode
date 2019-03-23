// Given a 2D board and a list of words from the dictionary, find all words in the board.

// Each word must be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once in a word.

// Example:

// Input: 
// words = ["oath","pea","eat","rain"] and board =
// [
//   ['o','a','a','n'],
//   ['e','t','a','e'],
//   ['i','h','k','r'],
//   ['i','f','l','v']
// ]

// Output: ["eat","oath"]

// Solution:    The easy way would be use DFS and search each of the string at each state. Like #79
//              But this approach combines the Trie tree structure #208 with DFS to get a better performance.
//              Trie tree is for searching strings in multiple strings. In this case, it's searching for the current DFS string in the words dictionary.
//              Using a pointer to search the string when iterating through the DFS states. 
//              SSSSSo good, referenced from the solutions.   


var DFS = function(board, words, trie, i, j, res){
    var c = board[i][j];
    
    if(trie.next[c] === undefined || board[i][j] === "#") {return;}
    board[i][j] = "#";
    
    if(trie.next[c].word != undefined){
        res.push(trie.next[c].word);
        trie.next[c].word = undefined;
        board[i][j] = c;
    }
    
    var pointer = trie.next[c];
    if(i + 1 < board.length)     DFS(board, words, pointer, i + 1, j, res);
    if(j + 1 < board[0].length)  DFS(board, words, pointer, i, j + 1, res);
    if(i - 1 >= 0)                DFS(board, words, pointer, i - 1, j, res);
    if(j - 1 >= 0)                DFS(board, words, pointer, i, j - 1, res);
    
    board[i][j] = c;
}

/**
 * @param {character[][]} board
 * @param {string[]} words
 * @return {string[]}
 */
var findWords = function(board, words) {
    var trie = new Trie();
    var res = [];
    for(var i = 0; i < words.length; i++){
        trie.insert(words[i], words[i]);
    }
    //console.log("");
    for(var i = 0; i < board.length; i++){
        for(var j = 0; j < board[0].length; j++){
            DFS(board, words, trie, i, j, res)
            //console.log(res);
        }
    }
    return res;
};



/**
 * Initialize your data structure here.
 */
var Trie = function() {
    this.next = new Object();
    this.end = false;
    this.word = undefined;
};

/**
 * Inserts a word into the trie. 
 * @param {string} word
 * @return {void}
 */
Trie.prototype.insert = function(word, originalWord) {
    if(word.length === 0 ) {
        this.end = true;
        this.word = originalWord;
        return;
    }
    if(this.next[word.slice(0,1)] === undefined){
        this.next[word.slice(0,1)] = new Trie();
    }
    this.next[word.slice(0,1)].insert(word.slice(1), originalWord)
};



