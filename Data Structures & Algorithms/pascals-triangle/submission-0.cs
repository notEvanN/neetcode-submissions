public class Solution
{
    public List<List<int>> Generate(int numRows)
    {
        if (numRows == 0)
            return new List<List<int>>();

        List<List<int>> triangle = Generate(numRows - 1);

        List<int> row = new List<int>();
        row.Add(1);

        if (triangle.Count > 0)
        {
            List<int> previous = triangle[triangle.Count - 1];

            for (int i = 1; i < previous.Count; i++)
            {
                row.Add(previous[i - 1] + previous[i]);
            }

            row.Add(1);
        }

        triangle.Add(row);

        return triangle;
    }
}