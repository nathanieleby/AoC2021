using System;
using System.Linq;



namespace AoC
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] inFile = GetInput.ReadInputFile();

            //Day2.Part1( inFile );
            //Day2.Part2( inFile );
            Console.WriteLine(Day3.Part1( inFile ));
            Console.WriteLine(Day3.Part2( inFile ));

        }

        
    }
}
