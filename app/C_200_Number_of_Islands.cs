using System;

namespace SolutionNamespace{
    class C_200_Number_of_Islands{
        public static int NumIslands(char[][] grid) {
            int count = 0;
            for(int i = 0; i < grid.Length; i++){
                for(int j = 0; j < grid[i].Length; j++){
                    if(grid[i][j] == '1'){
                        count++;
                        recursiveMarkGrid(grid, i, j);
                    }
                }
            }
            return count;
        }
        public static void recursiveMarkGrid(char[][] grid, int i, int j){
            grid[i][j] = '0';
            if(i+1 < grid.Length && grid[i+1][j] == '1')
                recursiveMarkGrid(grid, i + 1, j);

            if(j+1 < grid[0].Length && grid[i][j+1] == '1')
                recursiveMarkGrid(grid, i, j + 1);

            if(j  > 0 && grid[i][j-1] == '1')
                recursiveMarkGrid(grid, i, j-1);

            if(i > 0 && grid[i-1][j] == '1')
                recursiveMarkGrid(grid, i-1, j);
        }
    }
}
