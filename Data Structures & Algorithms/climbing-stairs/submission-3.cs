public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] memo = new int[n + 1];

        return Dfs(n, 0, memo);
    }

    public int Dfs(int n, int i, int[] memo)
    {
        // Reached the destination
        if (i == n)
            return 1;

        // Went past the destination
        if (i > n)
            return 0;

        // Already calculated this position
        if (memo[i] != 0)
            return memo[i];

        // Calculate and store the result
        memo[i] = Dfs(n, i + 1, memo)
                + Dfs(n, i + 2, memo);

        return memo[i];
    }
}