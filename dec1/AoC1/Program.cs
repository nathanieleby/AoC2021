using System;



namespace AoC1
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer   = 0;
            int current  = 0;
            int previous = 0;

            Console.WriteLine("Hello World!");
            string[] inFile = GetInput.ReadInputFile();

            Console.WriteLine(inFile.Length + "Waddup Bitch");

            for (int i = 1; i<inFile.Length; i++ )
            {
                int.TryParse(inFile[i], out current);
                int.TryParse(inFile[i-1], out previous);
                if (current > previous)
                {
                    answer += 1;
                }
            }

            Console.WriteLine(answer);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
