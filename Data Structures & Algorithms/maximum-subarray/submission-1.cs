public class Solution {
    public int MaxSubArray(int[] nums) {
        int cSum = nums[0];
        int mSum = nums[0];
        for (int i =1; i<nums.Length; i++) {
            cSum = Math.Max(nums[i], nums[i] + cSum);
            mSum = Math.Max(cSum,mSum);
        }
        return mSum;
    }
}
