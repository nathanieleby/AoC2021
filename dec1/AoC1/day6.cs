using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day6
    {
        static List<long> school = new List<long> ();
        static int result = 0;
        public static int Part1(string[] input)
        {

            result = 0;
            int newFish = 0;
            int days = 80;
            int i, j;

            parseInput(input);

            for (j = 0; j < days; j++)
            {
                newFish = 0;
                for (i = 0; i < school.Count; i++)
                {
                    if (school[i] == 0)
                    {
                        newFish++;
                        school[i] = 6;
                    }
                    else
                    {
                        school[i]--;
                    }
                }

                for (i = 0; i < newFish; i++)
                    school.Add(8);

                
            }

            result = school.Count;
            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            long temp = 0, total = 0;
            int days = 256;
            int i, j;

            school.Clear();
            parseInput(input);

            for (i = 0; i < days; i++)
            {
                for (j = 0; j < 9; j++)
                {
   
                   if(j == 0)
                        temp = school[0];

                   if (j == 8)
                    {
                        school[j] = temp;
                    }
                   else if(j == 6)
                    {
                        school[j] = school[j+1] + temp;
                    }
                   else
                    {
                        school[j] = school[j + 1];
                    }
                }
            }

            for (i = 0; i < school.Count; i++)
                total += school[i];

            return total;
        }

        private static void parseInput(string[] input)
        {
            int i, j;
            long temp = 0;
            string[] split = input[0].Split(',');

            for (i = 0; i < 9; i++)
                school.Add(0);

            for (i =0; i < split.Length; i++)
            {
                temp = (Int64.Parse(split[i]));

                for (j = 0; j < 7; j++)
                    if (temp == j)
                        school[j]++;

            }
         
            return;
        }
    }
}