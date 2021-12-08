using System;
using System.Collections.Generic;


namespace AoC
{
    
    class bingoGameCard
    {
        public int[][] Num { get; set; }
        public bool[][] Filled { get; set; }

        public bingoGameCard()
        {
 
        }
    }
    class Day4
    {
        public static List<bingoGameCard> cards = new List<bingoGameCard>();
        public static List<int> bingoNumbers = new List<int>();
        static int result = 0;
        public static int Part1(string[] numbers)
        {
            bingoGameCard card = new bingoGameCard();
            cards.Add(card);

            cards[0].Num[0][0] = 69;

            Console.WriteLine(cards[0].Num[0][0]);
            
            return result;
        }

        public static int Part2(string[] numbers)
        {
            

            return result;
        }
    }
}