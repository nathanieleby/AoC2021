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
        public List<string> connections = new List<string>();
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

                buildCave(temp[0], temp[1]);
                buildCave(temp[1], temp[0]);
            }

            for (i = 0; i < caves.Count; i++)
            {
                if (caves[i].small && caves[i].connections.Count == 1)
                {
                    if (char.IsLower(caves[i].connections[0][0]) &&
                        !caves[i].connections[0].Equals("end")   &&
                        !caves[i].connections[0].Equals("start"))  
                    {
                        caveDict.Remove(caves[i].name);
                        caves.RemoveAt(i);
                        i--;
                    }
                }
            }

            return;
        }
        private static cave buildCave(string name, string connection)
        {
            cave newCave = null;
            if (!caveDict.ContainsKey(name))
            {
                newCave = new cave(name);
                caveDict.Add(name, newCave);
                caves.Add(newCave);
                newCave.connections.Add(connection);
            }
            else if (caveDict.TryGetValue(name, out cave value))
            {
                if(!value.connections.Contains(connection))
                    value.connections.Add(connection);
            }
            return newCave;
        }
    }
}