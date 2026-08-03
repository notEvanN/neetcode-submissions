public class Solution {
    public int[] CountBits(int n) {
        int[] res = new int[n+1];
        for (int x=1; x<=n;x++) {
            for (int i=0;i<32;i++) {
                if ((x&(1<<i)) != 0) {
                    res[x]++;                }
            }
        }
        return res;
    }
}
