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

            for(i =0; i< input.Length;i++)
            {
                for (j = 0; j < input[i].Length; j++)
                {

                    //upper left corner
                    if (i == 0 && j == 0)
                        if (input[i][j] < input[i + 1][j] && 
                            input[i][j] < input[i][j + 1])
                                result = input[i][j] + 1;

                    //upper right corner
                    else if (i == 0 && j == input[1].Length - 1)
                        if (input[i][j] < input[i + 1][j] && input[i][j] < input[i][j - 1])
                                result = input[i][j] + 1;

                    //lower left corner
                    else if (i == input.Length - 1 && j == 0)
                        if (input[i][j] < input[i + 1][j] && input[i][j] < input[i][j + 1])
                                result = input[i][j] + 1;

                    //lower right corner
                    else if (i == input.Length - 1 && j == input[1].Length - 1)
                        if (input[i][j] < input[i + 1][j] && 
                            input[i][j] < input[i][j - 1])
                                result = input[i][j] + 1;

                    //top
                    else if (i == 0)
                        if (input[i][j] < input[i + 1][j] &&
                            input[i][j] < input[i][j + 1] &&
                            input[i][j] < input[i][j - 1])
                                result = input[i][j] + 1;

                    //left
                    else if (j == 0)
                        if (input[i][j] < input[i + 1][j] &&
                            input[i][j] < input[i - 1][j] &&
                            input[i][j] < input[i][j + 1])
                                result = input[i][j] + 1;

                    //right
                    else if (j == input[i].Length - 1)
                        if (input[i][j] < input[i + 1][j] &&
                            input[i][j] < input[i - 1][j] &&
                            input[i][j] < input[i][j - 1])
                                result = input[i][j] + 1;

                    //bottom
                    else if (j == input[i].Length - 1)
                        if (input[i][j] < input[i - 1][j] &&
                            input[i][j] < input[i][j + 1] &&
                            input[i][j] < input[i][j - 1])
                                result = input[i][j] + 1;
                    //center of grid
                    else
                        if (input[i][j] < input[i - 1][j] &&
                            input[i][j] < input[i + 1][j] &&
                            input[i][j] < input[i][j + 1] &&
                            input[i][j] < input[i][j - 1])
                                result = input[i][j] + 1;

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



        private static void parseInput(string[] input)
        {
            int i;

            for (i = 0; i < input.Length; i++)
            {

            }
            return;
        }
    }
}