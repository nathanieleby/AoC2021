using System;
using System.Linq;



namespace AoC
{

    class Program
    {
        static void Main(string[] args)
        {

            GetInput.ReadInputFileBingo();

            Console.WriteLine(Day4.Part1( GetInput.contents ));
            //Console.WriteLine(Day3.Part2( GetInput.contents ));

        }

        
    }
}
