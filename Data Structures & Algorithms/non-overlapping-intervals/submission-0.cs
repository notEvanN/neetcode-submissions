public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int res = 0;
        int t = intervals[0][1];
        for (int i =1; i<intervals.Length; i++) {
            int s = intervals[i][0];
            int e = intervals[i][1];
            if (s<t) {
                res++;
            } else {
                t = e;
            }
        }
        return res;
    }
}
