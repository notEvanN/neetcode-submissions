public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while (l<r) {
            int s = nums[l] + nums[r];
            if (s<target) {
                l++;
            } else if (s>target) {
                r--;
            } else {
                return new int[]{l + 1, r + 1};
            }
        }
        return new int[0];
    }
}