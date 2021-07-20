public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        var maxRow = image.Length;
        var maxCol = image[0].Length;
        var color = image[sr][sc];

        if(color != newColor) DFS(image, sr, sc, in newColor, in color, in maxRow, in maxCol);

        return image;
    }
    
    private void DFS(int[][] result, int row, int col, in int newColor, in int color, in int maxRow, in int maxCol)
    {
        if (result[row][col] != color) return;
        if (result[row][col] == color) result[row][col] = newColor;

        if (row >= 1) DFS(result, row - 1, col, in newColor, in color, in maxRow, in maxCol);
        if (col >= 1) DFS(result, row, col - 1, in newColor, in color, in maxRow, in maxCol);
        if (row + 1 < maxRow) DFS(result, row + 1, col, in newColor, in color, in maxRow, in maxCol);
        if (col + 1 < maxCol) DFS(result, row, col + 1, in newColor, in color, in maxRow, in maxCol);
    }
}