using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day8
    {
        const int oneLen = 2, fourLen = 4, sevenLen = 3, eightLen = 7;
        private static List<string[]> displays = new List<string[]>();
        static int result = 0;
        public static int Part1(string[] input)
        {
            result = 0;
            int i;

            parseInput(input);

            foreach (string[] sevSeg in displays)
            {
                for (i=0; i < sevSeg.Length; i++)
                {
                    if(sevSeg[i].Length == oneLen   ||
                       sevSeg[i].Length == fourLen  ||
                       sevSeg[i].Length == sevenLen ||
                       sevSeg[i].Length == eightLen)
                    {
                        result += 1;
                    }
                }
            }

            return result;
        }

        public static int Part2(string[] input)
        {
            result = 0;

            

            return result;
        }

        private static void parseInput(string[] input)
        {
            int i;

            for (i = 0; i < input.Length; i++)
            {
                string[] easy = input[i].Split('|', StringSplitOptions.RemoveEmptyEntries);

                displays.Add( easy[1].Split(' ', StringSplitOptions.RemoveEmptyEntries));
            }
            return;
        }
    }
}