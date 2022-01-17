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
        public uint accessed = 1;
        public List<string> connections = new List<string>();
        public bool small;

    }


    
    class Day12
    {
        private static int result = 0;
        private static Dictionary<string, string> paths = new Dictionary<string, string>();
        private static List<cave> caves = new List<cave>();
        static Dictionary<string, cave> caveDict = new Dictionary<string, cave>();

        public static int Part1(string[] input)
        {
            result = 0;
            int i = 0, j = 0, k = 0;


            parseInput(input);

            caveDict.TryGetValue("start", out cave value);
            findPath(value, null);
            result = paths.Count;

            paths.Clear();

            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            int i, j;

            foreach (cave myCave in caves)
            {
                myCave.accessed = 2;
                caveDict.TryGetValue("start", out cave value);
                findPath(value, null);
                myCave.accessed = 1;
            }
            result = paths.Count;

            return result;

        }

        private static void findPath(cave currentCave, string currentPath)
        {

            //check to see if we have been here in the current path
            if (currentCave.accessed <= 0)
                return;

            string path;

            if (currentCave.name == "start")
            {
                currentCave.accessed = 0;
                path = currentPath + currentCave.name;
            }
            else
                path = currentPath + ',' + currentCave.name;

            //check to see if we made it to the end
            if(currentCave.name == "end")
            {
                if(!paths.ContainsKey(path))
                    paths.Add(path, path);

                return;
            }

            //if the cave is small make sure we can't go through it again
            if(currentCave.small == true && currentCave.name != "start")
                currentCave.accessed--;
            
            //try all caves in the connection list
            foreach (string name in currentCave.connections)
            {
                caveDict.TryGetValue(name, out cave value);
                findPath(value, path);
            }

            //set cave back to accessible for the next path
            if (currentCave.small == true)
                currentCave.accessed++;

            return;
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