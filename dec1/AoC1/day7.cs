using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day7
    {
        private static List<int> crabPositions = new List<int>();
        static int result = 0;
        public static int Part1(string[] input)
        {
            result = 0;

            int i, j;
            int lowestExpense = 0;
            int temp = 0;

            parseInput(input);



            for (i = 0; i < crabPositions[crabPositions.Count-1]; i++)
            {
                
                temp = 0;
                
                foreach (int crab in crabPositions )
                    temp += Math.Abs(crab - i);

                if (i == 0)
                {
                    lowestExpense = temp;
                }
                else if (temp < lowestExpense)
                {
                    lowestExpense = temp;
                }
            }

            result = lowestExpense;

            return result;
        }

        public static int Part2(string[] input)
        {
            result = 0;

            int i, j;
            int lowestExpense = 0;
            int temp = 0;
            int distanceDiff = 0;

            parseInput(input);



            for (i = 0; i < crabPositions[crabPositions.Count - 1]; i++)
            {

                temp = 0;

                foreach (int crab in crabPositions)
                {
                    distanceDiff = Math.Abs(crab - i);

                    for (j = 1; j <= distanceDiff; j++)
                    {
                        temp += j;
                    }
                    

                }
                if (i == 0)
                {
                    lowestExpense = temp;
                }
                else if (temp < lowestExpense)
                {
                    lowestExpense = temp;
                }
            }


            result = lowestExpense;

            return result;
        }

        private static void parseInput(string[] input)
        {
            int i;
            string[] split = input[0].Split(',');

            crabPositions.Clear();

            for (i = 0; i < split.Length; i++)
            {
                crabPositions.Add( (Int32.Parse(split[i])));

            }
            crabPositions.Sort();

            for (i = 0; i < crabPositions[crabPositions.Count-1];i++)
            {
                //maybe this is nothing, but maybe we need an array from min value to max value
            }

            return;
        }
    }
}