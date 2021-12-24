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

        static errorLog errors;
        public static int Part1(string[] input)
        {
            result = 0;

            int i = 0, j = 0;
            int wasRemoved = 0;
            int closingExists = 0;

  

            for (i = 0; i < input.Length; i++)
            {
                for  (j = 0; j < input[i].Length; j++)
                {
                    
                    if (isClosingBracket(input[i][j]))
                    {
                        closingExists++;
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
                            }
                        }
                    }
                    
                }

                if ((closingExists > 0 || wasRemoved > 0) && input[i].Length > 0)
                {
                    i--;
                    wasRemoved = 0;
                    closingExists = 0;
                }

            }

            return result;
        }

        public static int Part2(string[] input)
        {
            result = 0;
            int i, j;
            


            return result;
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