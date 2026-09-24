public class Solution {
    public bool IsValid(string s) {
        Stack<char> a = new Stack<char>();
        Dictionary<char, char> d = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s) {
            if (d.ContainsKey(c)) {
                if (a.Count > 0 && a.Peek() == d[c]) {
                    a.Pop();
                } else {
                    return false;
                }
            } else {
                a.Push(c);
            }
        }
        return a.Count == 0;
        
    }
}
