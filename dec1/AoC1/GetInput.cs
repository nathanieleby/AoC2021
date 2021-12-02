using System;
using System.IO;

namespace AoC
{
    class GetInput
    {
        public static string[] ReadInputFile()
        {

            string[] contents = File.ReadAllLines("input.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }

        public static string[] ReadInputDay2()
        {

            string[] contents = File.ReadAllLines("input2.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }
    }
}