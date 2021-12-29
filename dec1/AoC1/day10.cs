using System;
using System.IO;
using System.Text;
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

        private static List<long> scores = new List<long>();

        private static List<string> inputList;
        public static int Part1(string[] input)
        {
            result = 0;

            inputList = new List<string>(input);

            int i = 0, j = 0;
            int wasRemoved = 0;
            int errorFound = 0;
  

            for (i = 0; i < inputList.Count; i++)
            {
                errorFound = 0;
                wasRemoved = 0;
                for  (j = 0; j < inputList[i].Length; j++)
                {
                    errorFound = 0;
                    if (isClosingBracket(inputList[i][j]))
                    {

                        if (inputList[i][j] == closingParen)
                        {
                            if (inputList[i][j - 1] == openParen)
                            {
                                inputList[i] = inputList[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(inputList[i][j - 1]))
                            {
                                logErrors(inputList[i][j]);
                                errorFound++;
                                inputList.RemoveAt(i);
                                i--;
                                break;
                            }

                        }
                        else if (inputList[i][j] == closingSquare)
                        {
                            if (inputList[i][j - 1] == openSquare) 
                            {
                                inputList[i] = inputList[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(inputList[i][j - 1]))
                            {
                                logErrors(inputList[i][j]);
                                errorFound++;
                                inputList.RemoveAt(i);
                                i--;
                                break;
                            }
                        }
                        else if (inputList[i][j] == closingCurly)
                        {
                            if (inputList[i][j - 1] == openCurly)
                            {
                                inputList[i] = inputList[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(inputList[i][j - 1]))
                            {
                                logErrors(inputList[i][j]);
                                errorFound++;
                                inputList.RemoveAt(i);
                                i--;
                                break;
                            }
                        }
                        else if (inputList[i][j] == closingAngle)
                        {
                            if (inputList[i][j - 1] == openAngle)
                            {
                                inputList[i] = inputList[i].Remove(j - 1, 2);
                                j = 0;
                                wasRemoved++;
                            }
                            else if (!isClosingBracket(inputList[i][j - 1]))
                            {
                                logErrors(inputList[i][j]);
                                errorFound++;
                                inputList.RemoveAt(i);
                                i--;
                                break;
                            }
                        }
                    }
                    
                }

                if (i >= 0)
                {
                    if (wasRemoved > 0 &&
                        inputList[i].Length > 0 &&
                        errorFound == 0)
                    {
                        i--;
                    }
                }
            }

            result += errors.parenErrors * lookup[0];
            result += errors.squareErrors * lookup[1];
            result += errors.curlyErrors * lookup[2];  
            result += errors.angleErrors * lookup[3];
            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            long result64 = 0;
            int i, j;
            StringBuilder sb = new StringBuilder();

            foreach (string line in inputList)
            {
                
                for(i = line.Length - 1; i >= 0; i--)
                {
                    if (line[i] == openParen)
                        sb.Append(closingParen);
                    if (line[i] == openSquare)
                        sb.Append(closingSquare);
                    if (line[i] == openCurly)
                        sb.Append(closingCurly);
                    if (line[i] == openAngle)
                        sb.Append(closingAngle);
                }
                string str1 = sb.ToString();
                scores.Add(scoreCorrections(str1));

                sb.Clear();
            }

            result64 = getMiddleScore();

            return result64;

        }

        

        private static long scoreCorrections(string corrections)
        {
            long score = 0;
            int i;
            for (i = 0; i < corrections.Length; i++)
            {
                score = 5 * score;
                if(corrections[i] == closingParen)
                {
                    score += 1;
                }
                else if (corrections[i] == closingSquare)
                {
                    score += 2;
                }
                else if (corrections[i] == closingCurly)
                {
                    score += 3;
                }
                else if (corrections[i] == closingAngle)
                {
                    score += 4;
                }

            }
            
            return score;
        }

        private static long getMiddleScore()
        {
            scores.Sort();
            
            return scores[scores.Count / 2];
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