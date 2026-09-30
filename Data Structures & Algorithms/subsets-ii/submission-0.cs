public class Solution
{
    public List<List<int>> SubsetsWithDup(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> subset = new List<int>();

        Array.Sort(nums);

        Backtrack(nums, 0, subset, result);

        return result;
    }

    private void Backtrack(
        int[] nums,
        int start,
        List<int> subset,
        List<List<int>> result)
    {
        // Every current subset is a valid answer
        result.Add(new List<int>(subset));

        for (int i = start; i < nums.Length; i++)
        {
            // Skip duplicates at the same level
            if (i > start && nums[i] == nums[i - 1])
                continue;

            // Choose
            subset.Add(nums[i]);

            // Explore
            Backtrack(nums, i + 1, subset, result);

            // Undo
            subset.RemoveAt(subset.Count - 1);
        }
    }
}