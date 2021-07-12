public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var result = 0;
        for (var row = 0; row < grid.GetLength(0); row++)
        {
            for (var col = 0; col < grid[row].Length; col++)
            {
                if (grid[row][col] == 0) continue;

                if (col == 0 || grid[row][col - 1] == 0) result++;
                if (row == 0 || grid[row - 1][col] == 0) result++;
                if (col == grid[row].Length - 1 || grid[row][col + 1] == 0) result++;
                if (row == grid.GetLength(0) - 1 || grid[row + 1][col] == 0) result++;
            }
        }
        return result;
    }
}