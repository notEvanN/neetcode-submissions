public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int s = n * (n+1)/2;
        int a = 0;
        foreach (int num in nums) {
            a += num;
        }
        return s-a;
        
    }
}
