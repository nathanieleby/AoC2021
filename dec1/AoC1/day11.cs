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
        const int steps = 100;

        private static List<int[]> octopusGrid = new List<int[]>();
        private static List<bool[]> hasFlashed = new List<bool[]>();
        public static int Part1(string[] input)
        {
            result = 0;
            int i = 0, j = 0, k = 0;

            //put the string array into an int list
            //initilize a grid to track if the octopus has flashed that round yet
            parseInput(input);

            //loop through all the steps
            for (k = 0; k < steps; k++)
            {
                for (i = 0; i < octopusGrid.Count; i++)
                {
                    for (j = 0; j < octopusGrid[i].Length; j++)
                    {
                        result += increaseEnergy(i, j);
                    }
                }

                resetFlashGrid();
                
            }

            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            int i, j;
            int flashCount = 0;
            int numberOfSteps = 100; // start at 100 to account for the 100 steps taken in part 1
            int gridSize = octopusGrid.Count * octopusGrid[0].Length;
            
            while(flashCount < gridSize)
            {
                numberOfSteps++;
                flashCount = 0;
                for (i = 0; i < octopusGrid.Count; i++)
                {
                    for (j = 0; j < octopusGrid[i].Length; j++)
                    {
                        flashCount = increaseEnergy(i, j);

                        if (flashCount >= gridSize)
                            break;
                    }
                    if (flashCount >= gridSize)
                        break;
                }

                resetFlashGrid();
            }

            result = numberOfSteps;

            return result;

        }

        private static int increaseEnergy(int i, int j)
        {
            int flashCounter = 0;
            
            if (hasFlashed[i][j] == true)
                return 0;


            if (octopusGrid[i][j] == 9)
            {
                octopusGrid[i][j] = 0;
                hasFlashed[i][j] = true;

                flashCounter++;

                //row above point
                if(i > 0 && j > 0)
                    flashCounter += increaseEnergy(i - 1, j - 1);
                if(i > 0)
                    flashCounter += increaseEnergy(i - 1, j);
                if(i > 0 && j < octopusGrid[i].Length - 1)
                    flashCounter += increaseEnergy(i - 1, j + 1);
                //same row as point
                if(j > 0)
                    flashCounter += increaseEnergy(i, j - 1);
                if(j < octopusGrid[i].Length - 1)
                    flashCounter += increaseEnergy(i, j + 1);
                //row below point
                if (i < octopusGrid.Count - 1 && j > 0)
                    flashCounter += increaseEnergy(i + 1, j - 1);
                if(i < octopusGrid.Count - 1)
                    flashCounter += increaseEnergy(i + 1, j);
                if (i < octopusGrid.Count - 1 && j < octopusGrid[i].Length - 1)
                    flashCounter += increaseEnergy(i + 1, j + 1);
            }
            else
                octopusGrid[i][j]++;

            return flashCounter;
        }

        private static int resetFlashGrid( )
        {
            int i, j, tempLength = 0;

            if (hasFlashed.Count>0)
                tempLength = hasFlashed[0].Length;

            for (i = 0; i < hasFlashed.Count; i++)
                hasFlashed[i] = new bool[tempLength];
            return 0;
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