public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        int indexS = 0, indexT = 0;
        while (indexT < t.Length) {
            if (t[indexT] == s[indexS]) {
                indexS++;
                if (indexS == s.Length) return true;
            }
            indexT++;
        }
        return false;
    }
}