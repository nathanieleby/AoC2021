using System;
using System.Linq;



namespace AoC1
{

    class Program
    {
        static void Day1Part1(string[] inFile)
        {
            int answer = 0;
            int current;
            int previous;

            for (int i = 1; i < inFile.Length; i++)
            {
                int.TryParse(inFile[i], out current);
                int.TryParse(inFile[i - 1], out previous);
                if (current > previous)
                {
                    answer += 1;
                }
            }

            Console.WriteLine(answer);
        }

        static void Day1Part2(string[] inFile)
        {
            int answer = 0;
            int[] first  = new int[3];
            int[] second = new int[3];

            int previous;
            int current;

            for (int i = 3; i < inFile.Length; i++)
            {
                int.TryParse(inFile[i - 1], out first[0]);
                int.TryParse(inFile[i - 2], out first[1]);
                int.TryParse(inFile[i - 3], out first[2]);

                int.TryParse(inFile[i],     out second[0]);
                int.TryParse(inFile[i - 1], out second[1]);
                int.TryParse(inFile[i - 2], out second[2]);


                if (first.Sum() < second.Sum())
                {
                    answer += 1;
                }
            }

            Console.WriteLine(answer);
        }
        static void Main(string[] args)
        {

            string[] inFile = GetInput.ReadInputFile();

            Console.WriteLine("Input File Lenght: " + inFile.Length );

            Day1Part1( inFile);
            Day1Part2( inFile);


            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }

        
    }
}
