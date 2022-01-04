using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{
    class cave
    {
        string name;
        bool accessed = false;
        string[] connections;
        bool small;

    }


    
    class Day12
    {
        static int result = 0;
        private static List<string[]> paths = new List<string[]>();

        static Dictionary<string, cave> caveDict = new Dictionary<string, cave>();
        public static int Part1(string[] input)
        {
            result = 0;
            int i = 0, j = 0, k = 0;



            parseInput(input);



            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            int i, j;
           

            return result;

        }



        private static void parseInput(string[] input)
        {
            int i = 0, j = 0;

            string[] temp;

            //example code @TODO remove later
            //caveDict.ContainsKey("start");
            //
            //caveDict.Add("start", new cave());

            for (i = 0; i < input.Length; i++)
            {

                temp = input[i].Split('-');

            }

            return;
        }
    }
}