class Solution {
    public int maxProfit(int[] prices) {
        int l = 0, r = 1, res = 0;
        while (r<prices.length) {
            if (prices[r] < prices[l]) {
                l = r;
            } else {
                int profit = prices[r] - prices[l];
                res = Math.max(profit,res);
            }
            r++;
        }
        return res;
        
    }
}
