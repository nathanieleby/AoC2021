using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day8
    {
        const int oneLen = 2, fourLen = 4, sevenLen = 3, eightLen = 7;
        const int lenOfFive = 5, lenOfSix = 6;
        private static List<string[]> displays = new List<string[]>();
        private static List<string[]> digits   = new List<string[]>();
        static int result = 0;
        public static int Part1(string[] input)
        {
            result = 0;
            int i;

            parseInput(input);

            foreach (string[] sevSeg in displays)
            {
                for (i=0; i < sevSeg.Length; i++)
                {
                    if(sevSeg[i].Length == oneLen   ||
                       sevSeg[i].Length == fourLen  ||
                       sevSeg[i].Length == sevenLen ||
                       sevSeg[i].Length == eightLen)
                    {
                        result += 1;
                    }
                }
            }

            return result;
        }

        public static int Part2(string[] input)
        {
            result = 0;
            int i, j;
            int fourIndex = 0, oneIndex = 0;
            char[] answer = {'0', '0', '0', '0' };


            for (i = 0; i <displays.Count;i++)
            {

                for (j = 0; j< digits[i].Length; j ++)
                {
                    if (digits[i][j].Length == oneLen)
                        oneIndex = j;
                    else if (digits[i][j].Length == fourLen)
                        fourIndex = j;
                }

                Array.Clear(answer, 0, answer.Length);
                for (j = 0; j<  displays[i].Length; j++)
                {
                    
                    switch (displays[i][j].Length)
                    {
                        case oneLen:
                            answer[j] = '1';
                            break;
                        case fourLen:
                            answer[j] = '4';
                            break;
                        case sevenLen:
                            answer[j] = '7';
                            break;
                        case eightLen:
                            answer[j] = '8';
                            break;
                        case lenOfFive:

                            if (compareNums(digits[i][oneIndex], displays[i][j]) == 2)
                                answer[j] = '3';
                            else if(compareNums(digits[i][fourIndex], displays[i][j]) == 3)
                                answer[j] = '5';
                            else
                                answer[j] = '2';

                            break;
                        case lenOfSix:

                            if (compareNums(digits[i][oneIndex], displays[i][j]) == 1)
                                answer[j] = '6';
                            else if (compareNums(digits[i][fourIndex], displays[i][j]) == 3)
                                answer[j] = '0';
                            else
                                answer[j] = '9';
                            break;

                        default:
                            answer[j] = '0';
                            break;
                    }

                    
                }
                string s = new string(answer);
                result += int.Parse(s);

            }           

            return result;
        }

        private static int compareNums(string compare, string other)
        {
            int i, j;
            int tally = 0;
            
            for(i =0; i<other.Length;i++)
            {
                for (j=0; j< compare.Length; j++)
                {
                    if (other[i] == compare[j])
                        tally += 1;
                }
            }

            return tally;
        }

        private static void parseInput(string[] input)
        {
            int i;

            for (i = 0; i < input.Length; i++)
            {
                string[] easy = input[i].Split('|', StringSplitOptions.RemoveEmptyEntries);

                digits.Add(easy[0].Split(' ', StringSplitOptions.RemoveEmptyEntries));
                displays.Add( easy[1].Split(' ', StringSplitOptions.RemoveEmptyEntries));
            }
            return;
        }
    }
}