using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{
    class cave
    {
        public cave(string caveName)
        {
            name = caveName;

            if (!Char.IsUpper(caveName[0]))
                small = true;
            else
                small = false;
        }

        public string name;
        public bool accessed = false;
        public string[] connections;
        public bool small;

    }


    
    class Day12
    {
        static int result = 0;
        private static List<string[]> paths = new List<string[]>();
        private static List<cave> caves = new List<cave>();
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

            for (i = 0; i < input.Length; i++)
            {

                temp = input[i].Split('-');

                if (!caveDict.ContainsKey(temp[j]))
                {
                    buildCave(temp[j]);
                }


            }

            return;
        }
        private static cave buildCave(string name)
        {
            cave newCave = new cave(name);
            caveDict.Add(name, newCave);
            caves.Add(newCave);

            return newCave;
        }
    }
}