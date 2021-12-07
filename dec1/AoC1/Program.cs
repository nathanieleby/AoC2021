using System;
using System.Linq;



namespace AoC
{

    class Program
    {
        static void Main(string[] args)
        {

            GetInput.ReadInputFile();

            Console.WriteLine(Day3.Part1( GetInput.contents ));
            Console.WriteLine(Day3.Part2( GetInput.contents ));

        }

        
    }
}
