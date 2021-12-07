﻿using System;
using System.Collections.Generic;

namespace AoC
{
    class Day3
    {
        public static int Part1(string[] numbers)
        {

            int i = 0, j = 0;
            int gamma   = 0;
            int epsilon = 0; 
            int tally   = 0;
            int mask    = 0;
            int result  = 0;

            for (i = 0; i < numbers[0].Length; i++)
            {
                tally = 0;
                for (j = numbers.Length - 1; j >= 0; j--)
                {
                    if (numbers[j][numbers[0].Length - i - 1] == '1')
                        tally += 1;

                }

                if (tally > numbers.Length/2)
                {
                    gamma |= 1 << i;
                }

                mask |= 1 << i;
            }                

            epsilon = ~gamma;
            epsilon &= mask;

            result = epsilon * gamma;
            return result;
        }

        public static int Part2(string[] numbers)
        {
            List<string> oxygenCode = new List<string>(numbers);
            List<string> co2Code    = new List<string>(numbers);

            int i = 0, j = 0;
            int gamma   = 0;
            int epsilon = 0;         
            int tally   = 0;
            int result  = 0;
            char mostCommon = '0';

            for (i = 0; i < oxygenCode[0].Length; i++)
            {
                tally = 0;
                for (j = oxygenCode.Count - 1; j >= 0; j--)
                {
                    if (oxygenCode[j][oxygenCode.Count - i - 1] == '1')
                        tally += 1;


                }

                if (tally >= (numbers.Length / 2) )
                {
                    mostCommon = '0';
                }
                else
                {
                    mostCommon = '1';
                }

                for (j = oxygenCode.Count - 1; j >= 0; j--)
                {
                    if (oxygenCode[j][oxygenCode.Count - i - 1] == mostCommon)
                        oxygenCode.RemoveAt(j);
                }

            }

            result = epsilon * gamma;

            return 0;
        }
    }
}