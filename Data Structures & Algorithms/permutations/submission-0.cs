public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Back(nums, 0, res);
        return res;
    }
    private void Back(int[] nums, int s,  List<List<int>> res) {
        if (s== nums.Length) {
            res.Add(new List<int>(nums));
            return;
        }
        for (int i = s; i< nums.Length; i++) {
            (nums[s], nums[i]) = (nums[i], nums[s]);
            Back(nums,s+1,res);
            (nums[s], nums[i]) = (nums[i], nums[s]);
        }
    }
}

