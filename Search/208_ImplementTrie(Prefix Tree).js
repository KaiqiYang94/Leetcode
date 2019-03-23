// Implement a trie with insert, search, and startsWith methods.

// Example:

// Trie trie = new Trie();

// trie.insert("apple");
// trie.search("apple");   // returns true
// trie.search("app");     // returns false
// trie.startsWith("app"); // returns true
// trie.insert("app");   
// trie.search("app");     // returns true
// Note:

// You may assume that all inputs are consist of lowercase letters a-z.
// All inputs are guaranteed to be non-empty strings.
// Accepted

// notes: the trie, is away to search for one string in multiple strings, it's only O(N) to find a string. 

/**
 * Initialize your data structure here.
 */
var Trie = function() {
    // the next part of the strings
    this.next = new Object();
    
    // the word ends here
    this.end = false;
};

/**
 * Inserts a word into the trie. 
 * @param {string} word
 * @return {void}
 */
Trie.prototype.insert = function(word) {
    if(word.length === 0 ) {
        this.end = true;
        return;
    }
    if(this.next[word.slice(0,1)] === undefined){
        this.next[word.slice(0,1)] = new Trie();
    }
    this.next[word.slice(0,1)].insert(word.slice(1))
};

/**
 * Returns if the word is in the trie. 
 * @param {string} word
 * @return {boolean}
 */
Trie.prototype.search = function(word) {
    if(word.length === 0) { return this.end;}
    if(this.next[word.slice(0,1)] != undefined){
        return (this.next[word.slice(0,1)]).search(word.slice(1));
    }
    return false;
};

/**
 * Returns if there is any word in the trie that starts with the given prefix. 
 * @param {string} prefix
 * @return {boolean}
 */
Trie.prototype.startsWith = function(prefix) {
    if(prefix.length === 0) { return true;}
    if(this.next[prefix.slice(0,1)] != undefined){
        return (this.next[prefix.slice(0,1)]).startsWith(prefix.slice(1));
    }
    return false;
};

/** 
 * Your Trie object will be instantiated and called as such:
 * var obj = Object.create(Trie).createNew()
 * obj.insert(word)
 * var param_2 = obj.search(word)
 * var param_3 = obj.startsWith(prefix)
 */