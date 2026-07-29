public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while (l<r) {
            int m = l + (r-l)/2;
            if (nums[m] < nums[r]) {
                r=m;
            } else {
                l = m+1;
            }
        }
        if (nums[0] == nums[l]) {
            int res = Array.BinarySearch(nums,0,nums.Length,target);
            if (res >= 0) {
                return res;
            } else {
                return -1;
            }
        } else if (target >=nums[0] && target <= nums[l-1]) {
            int res = Array.BinarySearch(nums,0,l,target);
            if (res >= 0) {
                return res;
            } else {
                return -1;
            }
        } else {
            int res = Array.BinarySearch(nums,l,nums.Length-l,target);
            if (res >= 0) {
                return res;
            } else {
                return -1;
            }
        }



        
    }
}
