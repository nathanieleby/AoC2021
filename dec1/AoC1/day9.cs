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
           public int i;
           public int j;
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
            int[] top3 = new int[3];

            foreach (XYPair lowPoint in xyPair)
            {
                result = 0;

                result = checkGrid(lowPoint.i, lowPoint.j);

                if (result > top3[0])
                {
                    top3[2] = top3[1];
                    top3[1] = top3[0];
                    top3[0] = result;
                }
                else if (result > top3[1])
                {
                    top3[2] = top3[1];
                    top3[1] = result;
                }
                else if (result > top3[2])
                {
                    top3[2] = result;
                }
            }
           
            result = top3[0] * top3[1] * top3[2];

            return result;
        }

        private static int checkGrid(int i, int j)
        {
            int sum = 0;

            accessed[i][j] = true;
            
            if(isValidSquare(i - 1, j))
                sum += checkGrid(i - 1, j);

            if (isValidSquare(i, j + 1))
                sum += checkGrid(i, j + 1);

            if (isValidSquare(i + 1, j))
                sum += checkGrid(i + 1, j);
            
            if (isValidSquare(i, j - 1))
                sum += checkGrid(i, j - 1);


            return sum + 1;
        }

        private static bool isValidSquare(int i, int j)
        {
            if (i < 0 ||
                j < 0 ||
                i > grid.Length - 1 ||
                j > grid[i].Length - 1 ||
                grid[i][j] == 9 ||
                accessed[i][j] == true)
                return false;
            else            
                return true;
        }

        private static void lowPointFound(int i, int j, int[][] grid)
        {
            XYPair temp = new XYPair();
            result += grid[i][j] + 1;

            temp.i = i;
            temp.j = j;

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