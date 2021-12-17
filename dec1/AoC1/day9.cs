using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day9
    {

        static int result = 0;
        public static int Part1(string[] input)
        {
            result = 0;
            int i, j;

            int[][] grid = parseInput(input);

            for(i =0; i< input.Length;i++)
            {
                for (j = 0; j < input[i].Length; j++)
                {

                    //upper left corner
                    if (i == 0 && j == 0)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i][j + 1])
                            result += grid[i][j] + 1;
                    }
                    //upper right corner
                    else if (i == 0 && j == grid[i].Length - 1)
                    {
                        if (grid[i][j] < grid[i + 1][j] && grid[i][j] < grid[i][j - 1])
                            result += grid[i][j] + 1;
                    }
                    //top
                    else if (i == 0)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i][j + 1] &&
                            grid[i][j] < grid[i][j - 1])
                            result += grid[i][j] + 1;
                    }
                    //lower left corner
                    else if (i == grid.Length - 1 && j == 0)
                    {
                        if (grid[i][j] < grid[i - 1][j] && grid[i][j] < grid[i][j + 1])
                            result += grid[i][j] + 1;
                    }
                    //left
                    else if (j == 0)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j + 1])
                            result += grid[i][j] + 1;
                    }
                    //lower right corner
                    else if (i == grid.Length - 1 && j == grid[i].Length - 1)
                    {
                        if (grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j - 1])
                            result += grid[i][j] + 1;
                    }
                    
                    //right
                    else if (j == grid[i].Length - 1)
                    {
                        if (grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j - 1])
                            result += grid[i][j] + 1;
                    }
                    
                    //bottom
                    else if (i == grid.Length - 1)
                    {
                        if (grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i][j + 1] &&
                            grid[i][j] < grid[i][j - 1])
                            result += grid[i][j] + 1;
                    }
                    //center of grid
                    else
                    {
                        if (grid[i][j] < grid[i - 1][j] &&
                            grid[i][j] < grid[i + 1][j] &&
                            grid[i][j] < grid[i][j + 1] &&
                            grid[i][j] < grid[i][j - 1])
                            result += grid[i][j] + 1;
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



        private static int[][] parseInput(string[] input)
        {
            int i = 0, j;
            int[][] grid = new int[input.Length][ ];

            for (i = 0; i < input.Length; i++)
            {
                grid[i] = new int[input[i].Length];

                for (j = 0; j < input[i].Length; j++)
                {
                    grid[i][j] = int.Parse(input[i][j].ToString());
                }

            }
            return grid;
        }
    }
}