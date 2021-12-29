using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class Day10
    {
        class errorLog
        {
            public int parenErrors;
            public int squareErrors;
            public int curlyErrors;
            public int angleErrors;
        }

        static int result = 0;

        static int[] lookup = {3, 57, 1197, 25137};
        static char closingParen   = ')';
        static char closingSquare  = ']';
        static char closingCurly   = '}';
        static char closingAngle   = '>';

        static char openParen  = '(';
        static char openSquare = '[';
        static char openCurly  = '{';
        static char openAngle  = '<';

        static string parenChunk  = "()";
        static string squareChunk = "[]";
        static string curlyChunk  = "{}";
        static string angleChunk  = "<>";

        static errorLog errors = new errorLog();
        public static int Part1(string[] input)
        {
            result = 0;

            int i = 0, j = 0;
            int wasRemoved = 0;
            int errorFound = 0;
  

            for (i = 0; i < input.Length; i++)
            {
                errorFound = 0;
                wasRemoved = 0;
                for  (j = 0; j < input[i].Length; j++)
                {
                    errorFound = 0;
                    if (isClosingBracket(input[i][j]))
                    {

                        if (input[i][j] == closingParen)
                        {
                            if (input[i][j - 1] == openParen)
                            {
                                input[i] = input[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(input[i][j - 1]))
                            {
                                logErrors(input[i][j]);
                                errorFound++;
                                break;
                            }

                        }
                        else if (input[i][j] == closingSquare)
                        {
                            if (input[i][j - 1] == openSquare) 
                            { 
                                input[i] = input[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(input[i][j - 1]))
                            {
                                logErrors(input[i][j]);
                                errorFound++;
                                break;
                            }
                        }
                        else if (input[i][j] == closingCurly)
                        {
                            if (input[i][j - 1] == openCurly)
                            {
                                input[i] = input[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(input[i][j - 1]))
                            {
                                logErrors(input[i][j]);
                                errorFound++;
                                break;
                            }
                        }
                        else if (input[i][j] == closingAngle)
                        {
                            if (input[i][j - 1] == openAngle)
                            {
                                input[i] = input[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(input[i][j - 1]))
                            {
                                logErrors(input[i][j]);
                                errorFound++;
                                break;
                            }
                        }
                    }
                    
                }

                if ( wasRemoved > 0     && 
                    input[i].Length > 0 && 
                    errorFound == 0)
                {
                    i--;
                }

            }

            result += errors.parenErrors * lookup[0];
            result += errors.squareErrors * lookup[1];
            result += errors.curlyErrors * lookup[2];  
            result += errors.angleErrors * lookup[3];
            return result;
        }

        public static int Part2(string[] input)
        {
            result = 0;
            int i, j;
            


            return result;
        }

        private static int removePair(string line, int index)
        {
            line = line.Remove(index - 1, 2);
            
            return 1;
        }

        private static void logErrors(char error)
        {
            if (error == closingParen)
                errors.parenErrors++;
            if (error == closingSquare)
                errors.squareErrors++;
            if (error == closingCurly)
                errors.curlyErrors++;
            if (error == closingAngle)
                errors.angleErrors++;
        }

        private static bool isClosingBracket(char bracket)
        {
            if (bracket == closingParen ||
                bracket == closingSquare ||
                bracket == closingCurly ||
                bracket == closingAngle )
                return true;
            else
                return false;
        }

        private static void parseInput(string[] input)
        {
            int i = 0, j = 0;


            for (i = 0; i < input.Length; i++)
            {


                for (j = 0; j < input[i].Length; j++)
                {

                }

            }
            return;
        }
    }
}