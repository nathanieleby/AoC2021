using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day11
    {


        static int result = 0;

        private static List<int[]> octopusGrid = new List<int[]>();
        private static List<bool[]> hasFlashed = new List<bool[]>();
        public static int Part1(string[] input)
        {
            result = 0;
            int i = 0, j = 0;

            parseInput(input);

            for(i = 0; i< octopusGrid.Count; i++)
            {
                for(j = 0; j < octopusGrid[i].Length; j++)
                {
                    increaseEnergy(i , j);
                }
            }
            
            

            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            

            return result;

        }

        private static void increaseEnergy(int i, int j)
        {
            if (hasFlashed[i][j] == true)
                return;

            int k, l;

            if (octopusGrid[i][j] == 9)
            {
                octopusGrid[i][j] = 0;
                hasFlashed[i][j] = true;

                increaseEnergy(i - 1, j - 1);
                increaseEnergy(i - 1, j);
                increaseEnergy(i - 1, j + 1);
                
                increaseEnergy(i, j - 1);
                increaseEnergy(i, j + 1);

                increaseEnergy(i + 1, j - 1);
                increaseEnergy(i + 1, j);
                increaseEnergy(i + 1, j + 1);
            }
            else
                octopusGrid[i][j]++;
        }


        private static void parseInput(string[] input)
        {
            int i = 0, j = 0;
            string temp;

            octopusGrid.Clear();
            hasFlashed.Clear();

            for (i = 0; i < input.Length; i++)
            {
                octopusGrid.Add(new int[input[i].Length]);
                hasFlashed.Add(new bool[input[i].Length]);

                for (j = 0; j < input[i].Length; j++)
                {
                    octopusGrid[i][j] = int.Parse(input[i][j].ToString());
                }

            }
            return;
        }
    }
}