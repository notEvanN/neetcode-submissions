public class Solution {
    public string LongestPalindrome(string s) {
        int a = 0, b = 0;
        
        //odd
        for (int i=0;i<s.Length;i++) {
            int l = i - 1, r = i + 1;
            while ( l >= 0 && r < s.Length && s[l] == s[r]) {
                l--;r++;
            }
            int len = r - l - 1;
            if (len > b) {
                b = len;
                a = l + 1;
            }
        }

        //even
        for (int i=0;i<s.Length;i++) {
            int l = i, r = i + 1;
            while ( l >= 0 && r < s.Length && s[l] == s[r]) {
                l--;r++;
            }
            int len = r - l - 1;
            if (len > b) {
                b = len;
                a = l + 1;
            }
        }
        return s.Substring(a, b);
    }
}
