using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day5
    {
        static List<int[]> parsedCoordinates = new List<int[]>();
        static int result = 0;
        public static int Part1(string[] coordinates)
        {
            parseInput(coordinates);
            
            return result;
        }

        public static int Part2(string[] coordinates)
        {
            
            return result;
        }

        private static void parseInput(string[] coordinates)
        {
            Char[] delimiters = { ',', '-', '>' };

            int i, j;


            for (i = 0; i < coordinates.Length; i++)
            {
                int[] temp = new int[4];
                for (j = 0; j < 4; j++)
                {
                   temp[j]  = Int32.Parse(coordinates[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries)[j]);
                }
                parsedCoordinates.Add(temp);
            }

            return ;
        }

    }
}