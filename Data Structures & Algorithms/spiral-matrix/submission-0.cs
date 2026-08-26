public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        List<int> res = new List<int>();
        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right) {
            // Step 1: go right along top row
            for (int j = left; j <= right; j++) {
                res.Add(matrix[top][j]);
            }
            top++;

            // Step 2: go down along right column
            for (int i = top; i <= bottom; i++) {
                res.Add(matrix[i][right]);
            }
            right--;

            // Step 3: go left along bottom row (only if still valid)
            if (top <= bottom) {
                for (int i = right; i >= left; i--) {
                    res.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            // Step 4: go up along left column (only if still valid)
            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    res.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return res;
    }
}