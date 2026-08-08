public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0) {
            return 0;
        }
        int l = 0, r = height.Length - 1, ml=height[l], mr=height[r], w=0;
        while (l<r) {
            if (ml<mr) {
                l++;
                ml = Math.Max(ml,height[l]);
                w += ml - height[l];
            } else {
                r--;
                mr = Math.Max(mr,height[r]);
                w += mr - height[r];
            }
        }
        return w;
    }
}
