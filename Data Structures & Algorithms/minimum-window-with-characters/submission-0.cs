public class Solution {
    public string MinWindow(string s, string t) {
        if (t == "" ) return "";

        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> w = new Dictionary<char, int>();

        foreach (char c in t) {
            if (countT.ContainsKey(c)) {
                countT[c]++;
            } else {
                countT[c] = 1;
            }
        }

        int h = 0, n = countT.Count, l = 0;
        int[] res = {-1,-1};
        int resL = int.MaxValue;

        for (int r=0;r<s.Length;r++) {
            char c = s[r];
            if (w.ContainsKey(c)) {
                w[c]++;
            } else {
                w[c] = 1;
            }

            if (countT.ContainsKey(c) && countT[c] == w[c]) {
                h++;
            }

            while (h==n) {
                int sum = r - l + 1;
                if (sum < resL) {
                    resL = sum;
                    res[0] = l;
                    res[1] = r;
                }

                char a = s[l];
                if (countT.ContainsKey(a) && countT[a] == w[a] ) {
                    h--;
                }
                w[a]--;
                l++;
            }
        }

        return resL == int.MaxValue ? "" : s.Substring(res[0],resL);

        
    }
}
