public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] memo = new int[cost.Length];

        Array.Fill(memo, -1);

        return Math.Min(
            f(cost, 0, memo),
            f(cost, 1, memo)
        );
    }

    private int f(int[] cost, int i, int[] memo)
    {
        if (i >= cost.Length)
        {
            return 0;
        }

        // Already calculated
        if (memo[i] != -1)
        {
            return memo[i];
        }

        // Calculate and save
        memo[i] = cost[i] + Math.Min(
            f(cost, i + 1, memo),
            f(cost, i + 2, memo)
        );

        return memo[i];
    }
}