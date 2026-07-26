public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) return "";
        List<int> size = new List<int>();
        StringBuilder res = new StringBuilder();
        foreach (string s in strs) {
            size.Add(s.Length);
        }
        foreach (int i in size) {
            res.Append(i).Append(",");
        }
        res.Append("#");
        foreach (string s in strs) {
            res.Append(s);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        if (s.Length == 0) {
            return new List<String>();
        }
        List<int> size = new List<int>();
        List<string> res = new List<string>();
        int i = 0;
        while (s[i] != '#') {
            int j = i;
            while (s[j] != ',') {
                j++;
            }
            size.Add(int.Parse(s.Substring(i,j-i)));
            i=j+1;
        }
        i++;
        foreach (int x in size) {
            res.Add(s.Substring(i,x));
            i += x;
        }
        return res;
   }
}
