using System;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{
    
    class bingoGameCard
    {
        public int[,] Num       = new int[5,5];
        public bool[,] Filled   = new bool[5,5];
        public bool hasWon = false;

        public bingoGameCard()
        {
 
        }
    }
    class Day4
    {
        public static List<bingoGameCard> cards = new List<bingoGameCard>();
        public static List<int> bingoNums = new List<int>();
        static int result = 0;
        public static int Part1()
        {

            int i, j, k;
            foreach (int number in bingoNums) 
            {
                for (k = 0; k < cards.Count; k++)
                {
                    placeNumber(cards[k], number);

                    if (isWinner(cards[k]))
                    {
                        result = number * scoreCard(cards[k]);
                        return result;
                    }
                }
            }
            return result;
        }

        public static int Part2()
        {
            int i, j, k;
            int hasWonCount = 0;
            int loopCount = 0;
            result = 0; 
            
            foreach (int number in bingoNums)
            {
                for (k = 0; k < cards.Count; k++)
                {

                    placeNumber(cards[k], number);

                    if (isWinner(cards[k]))
                    {
                        if(cards[k].hasWon == false)
                        {
                            hasWonCount++;
                            cards[k].hasWon = true;
                        }
                        if (cards.Count == hasWonCount)
                        {
                            result = number * scoreCard(cards[k]);
                            return result;
                        }
                    }
                }
                loopCount++;
            }
            return result;
        }

        private static int placeNumber(bingoGameCard card, int number)
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (card.Num[i, j] == number)
                        card.Filled[i, j] = true;
                }
            }
            return number;
        }
        private static bool isWinner(bingoGameCard card)
        {
            bool didWin = false;
            int i, j;
            int[] colsScore = new int[5];
            int[] rowsScore = new int[5];

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (card.Filled[i, j] == true)
                    {
                        colsScore[j] += 1;
                        rowsScore[i] += 1;
                    }
                    
                }

            }
            for (i = 0; i < 5; i++)
            {
                if (colsScore[i] == 5 || rowsScore[i] == 5)
                {
                    didWin = true;
                }
            }

            return didWin;
        }

        private static int scoreCard(bingoGameCard card)
        {
            int score = 0;

            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (card.Filled[i, j] == false)
                    {
                        score += card.Num[i, j];
                    }
                }

            }

            return score;
        }
    }
}