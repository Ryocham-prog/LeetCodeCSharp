public class Solution {
    // DFSではない解き方(192 ms)
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

// -------------------------------------------------------

    // DFS(180 ms)
        public int IslandPerimeter(int[][] grid) {
        var result = 0;
        
        var row = grid.Length;
        var col = grid[0].Length;
        
        for (var i = 0; i < row; i++){
            for (var j = 0; j < col; j++){
                if (grid[i][j] == 1){
                    result += DFS(grid, i, j, row, col);
                }
            }
        }
        return result;
    }
    
    private int DFS(int[][] grid, int i, int j, int row, int col){
        int res = 0;
        if(i >= 0 && i < row && j >= 0 && j < col && grid[i][j] == 1){
            grid[i][j] = -1;
            
            if(i == 0) // 最上部
                res++;
            
            if(i == row - 1) // 最下部
                res++;
            
            if(j == 0) // 最左
                res++;
            
            if(j == col - 1) // 最右
                res++;
            
            if(i > 0 && grid[i - 1][j] == 0) // 上部
                res++;
            
            if(i < row - 1 && grid[i + 1][j] == 0) // 下部
                res++;
            
            if(j > 0 && grid[i][j - 1] == 0) // 左
                res++;
            
            if(j < col - 1 && grid[i][j + 1] == 0) // 右
                res++;
            
            res += DFS(grid, i + 1, j, row, col);
            res += DFS(grid, i - 1, j, row, col);
            res += DFS(grid, i, j + 1, row, col);
            res += DFS(grid, i, j - 1, row, col);
        }
        return res;
    }
}
