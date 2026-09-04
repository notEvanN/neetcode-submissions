public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo((b[0])));
        List<int[]> res = new List<int[]>{};
        res.Add(intervals[0]);
        foreach (int[] interval in intervals) {
            int cs = interval[0];
            int ce = interval[1];
            int le = res[res.Count -1][1];
            if (cs <= le) {
                res[res.Count - 1][1] = Math.Max(le,ce);
            } else {
                res.Add(new int[]{cs,ce});
            }
        }
        return res.ToArray();
    }
}
