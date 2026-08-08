public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0) {
            return 0;
        }
        int l = 0, r = height.Length - 1, mL = height[l], mR = height[r], w = 0;
        while (l<r) {
            if (mL < mR) {
                l++;
                mL = Math.Max(mL,height[l]);
                w += mL - height[l];
            } else {
                r--;
                mR = Math.Max(mR,height[r]);
                w += mR - height[r];
            }
        }
        return w;
    }
}
