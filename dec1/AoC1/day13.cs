using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{

    class dot
    {
        public int x;
        public int y;

        public dot(int inX, int inY)
        {
            x = inX;
            y = inY;
        }
    }

    class fold
    {
        public char axis;
        public int  foldIndex;

        public fold(char a, int f)
        {
            axis = a;
            foldIndex = f;
        }
    }

    class paper
    {
        public int height;
        public int width;
        public bool[,] grid;
    }

    class Day13
    {
        private static int result = 0;

        static List<fold> folds = new List<fold>();
        static List<dot>  dots  = new List<dot>();

        static paper page = new paper();
        public static int Part1(string[] input)
        {
            result = 0;
            int i = 0, j = 0, k = 0;
            int paperWidth, paperLength;


            parseInput(input);

            paperLength  = page.grid.GetLength(0);
            paperWidth   = page.grid.GetLength(1);

            foreach ( fold line in folds )
            {


                if (line.axis == 'x')
                {

                }
                else if (line.axis == 'y')
                {

                }
            }

            return result;
        }

        public static long Part2(string[] input)
        {
            result = 0;
            int i, j;

           

            return result;

        }

        private void doFold(int length, int foldIndex)
        {
            int newLength;
            
            if (foldIndex < length / 2)
                newLength = length - foldIndex;
            if (foldIndex > length / 2)
                newLength = foldIndex - 1;
            if (foldIndex == length / 2)
            {
                newLength = length / 2;
            }

            
        }


        private static void parseInput(string[] input)
        {
            int i = 0, j = 0;

            string[] temp;
            int tempIndex = 0;
            int tempX, tempY;

            for (i = 0; i < input.Length; i++)
            {
               temp = input[i].Split(',');

                //this whole if is messy as F**K
                if (temp.Length != 2)
                {
                    tempIndex = temp[0].IndexOf('=');
                    if (tempIndex > 0)
                        folds.Add(new fold(temp[0][tempIndex - 1], int.Parse(temp[0][tempIndex + 1].ToString())));
                }
                else if (temp.Length == 2)
                {
                    tempX = int.Parse(temp[0]);
                    tempY = int.Parse(temp[1]);

                    if (tempX > page.height)
                        page.height = tempX;
                    if (tempY > page.width)
                        page.width = tempY;

                    dots.Add(new dot(tempX, tempY));
                }
                    
            }

            page.height++;
            page.width++;

            page.grid = new bool[page.height, page.width];

            foreach (dot element in dots)
            {
                page.grid[element.x,element.y] = true;
            }

            return;
        }
       
    }
}