/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        int n = intervals.Count;
        int [] start = new int[n];
        int [] end = new int[n];
        for (int i = 0; i < n; i++) {
            start[i] = intervals[i].start;
            end[i] = intervals[i].end;
        }
        Array.Sort(start);
        Array.Sort(end);
        int s = 0, e = 0, m = 0, max = 0;
        while (s<n) {
            if (start[s] < end[e]) {
                m++;
                s++;
                max = Math.Max(m,max);
            } else {
                m--;
                e++;
                max = Math.Max(m,max);
            }
        }
        return max;
    }
}
