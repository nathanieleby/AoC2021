using System;
using System.IO;

namespace AoC
{
    class GetInput
    {
        public static string[] contents;
        public static string[] ReadInputFile()
        {

            contents = File.ReadAllLines("input.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }

        public static string[] ReadInputFileBingo()
        {

            contents = File.ReadAllLines("input.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }
    }
}