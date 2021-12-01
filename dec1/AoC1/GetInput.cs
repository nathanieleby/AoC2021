using System;
using System.IO;

namespace AoC1
{
    class GetInput
    {
        public static string[] ReadInputFile()
        {
            Console.WriteLine("This is the input function");
            //FileStream inputFile = File.OpenRead("input.txt");

            string[] contents = File.ReadAllLines("input.txt");

            return contents;
        }
    }
}