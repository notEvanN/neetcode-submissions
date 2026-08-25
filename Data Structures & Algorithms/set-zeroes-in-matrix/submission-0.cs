public class Solution {
    public void SetZeroes(int[][] matrix) {
        int r = matrix.Length;
        int c = matrix[0].Length;

        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();

        for (int i = 0; i < r; i++) {
            for (int j = 0; j< c; j++) {
                if (matrix[i][j] == 0 ) {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        for (int i = 0; i < r; i++) {
            for (int j = 0; j< c; j++) {
                if (rows.Contains(i) || cols.Contains(j) ) {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
