public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> res = new HashSet<int>();
        
        while (!res.Contains(n)) {
            res.Add(n);
            n = Sum(n);
            if (n==1) {
                return true;
            }
        }
        return false;
    }

    private int Sum(int n) {
        int i = 0;
        while (n>0) {
            int j = n % 10;
            j = j * j;
            i += j;
            n /= 10;
        }
        return i;
    }
}
