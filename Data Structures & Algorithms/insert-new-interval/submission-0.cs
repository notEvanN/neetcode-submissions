public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new List<int[]>();
        int ns = newInterval[0], ne = newInterval[1];
        bool inserted = false;
        foreach (int[] interval in intervals) {
            int s = interval[0];
            int e = interval[1];
            if (e<ns) {
                res.Add(new int[]{s,e});
            } else if (s>ne) {
                if (!inserted) {
                    res.Add(new int[]{ns,ne});
                    inserted = true;
                }
                res.Add(new int[]{s,e});
            } else {
                ns = Math.Min(ns,s);
                ne = Math.Max(ne,e);
            }
        }
        if (!inserted) {
            res.Add(new int[]{ns,ne});
            inserted = true;
        }
        return res.ToArray();
    }
}
