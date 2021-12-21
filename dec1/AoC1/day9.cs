using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day9
    {
        class XYPair
        {
           public int x;
           public int y;
        }
        
        
        static int result = 0;
        static bool[][] accessed;
        private static  List<XYPair> xyPair = new List<XYPair>();
        private static  int[][] grid;

        public static int Part1(string[] input)
        {
            result = 0;
            int i, j;

            grid = parseInput(input);

            for(i =0; i< input.Length;i++)
            {
                for (j = 0; j < input[i].Length; j++)
                {

                    //upper left corner
                    if (i == 0 && j == 0)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i][j + 1])
                            lowPointFound(i, j, grid);                                     
                    }
                    //upper right corner
                    else if (i == 0 && j == grid[i].Length - 1)
                    {
                        if (grid[i][j] < grid[i + 1][j] && 
                            grid[i][j] < grid[i][j - 1])
                            lowPointFound(i, j, grid);
                    }
                    //top
                    else if (i == 0)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i][j + 1] &&
                            grid[i][j] < grid[i][j - 1])
                            lowPointFound(i, j, grid);
                    }
                    //lower left corner
                    else if (i == grid.Length - 1 && j == 0)
                    {
                        if (grid[i][j] < grid[i - 1][j] && 
                            grid[i][j] < grid[i][j + 1])
                            lowPointFound(i, j, grid);
                    }
                    //left
                    else if (j == 0)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j + 1])
                            lowPointFound(i, j, grid);
                    }
                    //lower right corner
                    else if (i == grid.Length - 1 && j == grid[i].Length - 1)
                    {
                        if (grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j - 1])
                            lowPointFound(i, j, grid);
                    }
                    
                    //right
                    else if (j == grid[i].Length - 1)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j - 1])
                            lowPointFound(i, j, grid);
                    }
                    
                    //bottom
                    else if (i == grid.Length - 1)
                    {
                        if (grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j + 1] &&
                            grid[i][j] < grid[i][j - 1])
                            lowPointFound(i, j, grid);
                    }
                    //center of grid
                    else
                    {
                        if (grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i][j + 1] &&
                            grid[i][j] < grid[i][j - 1])
                            lowPointFound(i, j, grid);
                    }
                }
            }

            return result;
        }

        public static int Part2(string[] input)
        {
            result = 0;
            int i, j;


            return result;
        }

        private static int checkGrid(int i, int j)
        {
            if (i < 0 ||
                j < 0 ||
                i > grid.Length -1 ||
                i > grid[i].Length - 1
                )
                return 0;

            return 1;
        }

        private static void lowPointFound(int i, int j, int[][] grid)
        {
            XYPair temp = new XYPair();
            result += grid[i][j] + 1;

            temp.x = i;
            temp.y = j;

            xyPair.Add(temp);
        }

        private static int[][] parseInput(string[] input)
        {
            int i = 0, j;
            int[][] grid = new int[input.Length][ ];

            accessed = new bool[input.Length][];

            for (i = 0; i < input.Length; i++)
            {
                grid[i]     = new int[input[i].Length];
                accessed[i] = new bool[input[i].Length];

                for (j = 0; j < input[i].Length; j++)
                {
                    grid[i][j]     = int.Parse(input[i][j].ToString());
                    accessed[i][j] = false;
                }

            }
            return grid;
        }
    }
}