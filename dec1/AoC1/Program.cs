﻿using System;
using System.Linq;



namespace AoC
{

    class Program
    {
        static void Main(string[] args)
        {

            string [] input = GetInput.ReadInputFile();

            Console.WriteLine("Part1 Answer:" + Day10.Part1(input));
            Console.WriteLine("Part2 Answer:" + Day10.Part2(input));

        }
        
    }
}
