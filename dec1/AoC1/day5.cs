using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day5
    {
        const int x1 = 0, x2 = 2, y1 = 1, y2 = 3;
        static List<int[]> parsedCoordinates = new List<int[]>();
        static int result = 0;
        public static int Part1(string[] coordinates)
        {
 
            int i =0, j=0, k=0;
            int[,] grid = new int[1000, 1000];
            result = 0;

            parseInput(coordinates);

            foreach ( int[] coords in parsedCoordinates  )
            {
                if (coords[x1] == coords[x2])
                {
                    i = coords[x1];
                    for (j = lower(coords[y1], coords[y2]); j <= higher(coords[y1], coords[y2]); j++)
                    {
                        grid[i, j]++;
                    }
                }
                else if (coords[y1] == coords[y2])
                {
                    j = coords[y1];
                    for (i = lower(coords[x1], coords[x2]); i <= higher(coords[x1], coords[x2]); i++)
                    {
                        grid[i, j]++;
                    }
                }
                
            }

            getGridNumber(grid);

            return result;
        }

        public static int Part2(string[] coordinates)
        {
            int i = 0, j = 0, k = 0;
            int[,] grid = new int[1000, 1000];
            result = 0;

           
            parseInput(coordinates);

            foreach (int[] coords in parsedCoordinates)
            {
                if (coords[x1] == coords[x2])
                {
                    i = coords[x1];
                    for (j = lower(coords[y1], coords[y2]); j <= higher(coords[y1], coords[y2]); j++)
                    {
                        grid[i, j]++;
                    }
                }
                else if (coords[y1] == coords[y2])
                {
                    j = coords[y1];
                    for (i = lower(coords[x1], coords[x2]); i <= higher(coords[x1], coords[x2]); i++)
                    {
                        grid[i, j]++;
                    }
                }
                else if (coords[y2] > coords[y1] )
                {
                    if (coords[x2] > coords[x1])
                        for (i = coords[x1], j = coords[y1]; i <= coords[x2]; i++, j++)
                            grid[i, j]++;
                    else if(coords[x2] < coords[x1])
                        for (i = coords[x1], j = coords[y1]; i >= coords[x2]; i--, j++)
                            grid[i, j]++;
                }
                else if (coords[y2] < coords[y1])
                {
                    if (coords[x2] > coords[x1])
                        for (i = coords[x1], j = coords[y1]; i <= coords[x2]; i++, j--)
                            grid[i, j]++;
                    else if (coords[x2] < coords[x1])
                        for (i = coords[x1], j = coords[y1]; i >= coords[x2]; i--, j--)
                            grid[i, j]++;
                }

            }

            getGridNumber(grid);

            return result;
        }

        private static int getGridNumber(int[,] grid)
        {
            result = 0;
            int i, j;
            for (i = 0; i < 1000; i++)
            {
                for (j = 0; j < 1000; j++)
                {
                    if (grid[i, j] > 1)
                        result++;
                }
            }
            return result;
        }
        private static int lower(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        private static int higher(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        private static float lineSlope(int[] coords)
        {
            float slope = (coords[y2] - coords[y1]) / (coords[x2] - coords[x1]);

            return slope;
        }
        private static void parseInput(string[] coordinates)
        {
            Char[] delimiters = { ',', '-', '>' };

            int i, j;

            parsedCoordinates.Clear();

            for (i = 0; i < coordinates.Length; i++)
            {
                int[] temp = new int[4];
                for (j = 0; j < 4; j++)
                {
                   temp[j]  = Int32.Parse(coordinates[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries)[j]);
                }
                parsedCoordinates.Add(temp);
            }

            for (i = 0; i < parsedCoordinates.Count; i++)
            {
                if ((parsedCoordinates[i][x1] != parsedCoordinates[i][x2]) && 
                    (parsedCoordinates[i][y1] != parsedCoordinates[i][y2])                     )
                {
                    if (Math.Abs(lineSlope(parsedCoordinates[i])) != 1)
                    {
                        parsedCoordinates.RemoveAt(i);
                        i--;
                    }
                }
            }

            return ;
        }

    }
}