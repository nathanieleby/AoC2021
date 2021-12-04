using System;
using System.Collections.Generic;

namespace AoC
{
    class Day3
    {
        public static int Part1(string[] numbers)
        {
           
            int i=0, j=0, gamma=0, epsilon=0, tally = 0;

            for (i = numbers[j].Length-1 ; i >= 0 ; i--)
            {
                tally = 0;
                for (j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j][i] == '1')
                        tally += 1;


                }

                if (tally > numbers.Length/2)
                {
                    epsilon |= ( 1 << i );
                }
            }



            int result = epsilon * gamma;

            Console.WriteLine(epsilon);
            Console.WriteLine("Answer  1 = " + result );

            return result;
        }

        public static int Part2(string[] numbers)
        {


            Console.WriteLine("Answer  2 = " );

            return 0;
        }
    }
}