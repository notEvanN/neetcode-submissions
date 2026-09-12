public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> countS = new Dictionary<char,int>();
        Dictionary<char, int> countT = new Dictionary<char,int>();

        for (int i = 0; i<s.Length;i++) {
            char a = s[i], b = t[i];
            countS[a] = countS.GetValueOrDefault(a,0) + 1;
            countT[b] = countT.GetValueOrDefault(b,0) + 1;

        }
        return countS.Count == countT.Count && !countS.Except(countT).Any();
    }
}
