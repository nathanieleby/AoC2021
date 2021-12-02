using System;
using System.IO;

namespace AoC
{
    class GetInput
    {
        public static string[] ReadInputFile()
        {
            Console.WriteLine("This is the input function");
            //FileStream inputFile = File.OpenRead("input.txt");

            string[] contents = File.ReadAllLines("input.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }
    }
}