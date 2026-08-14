public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length, g = n-1;
        for (int i = n - 2; i >= 0; i--) {
            if (nums[i] + i >= g) {
                g = i;
            }
        }
        return g == 0;

    }
}
