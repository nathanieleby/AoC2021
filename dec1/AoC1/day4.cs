using System;
using System.Collections;
using System.Collections.Generic;


namespace AoC
{
    
    class bingoGameCard
    {
        public int[,] Num       = new int[5,5];
        public bool[,] Filled   = new bool[5,5];

        public bingoGameCard()
        {
 
        }
    }
    class Day4
    {
        public static List<bingoGameCard> cards = new List<bingoGameCard>();
        public static List<int> bingoNums = new List<int>();
        static int result = 0;
        public static int Part1(string[] numbers)
        {
            var card = new bingoGameCard();
            
            card.Num[0,4] = 69;
            cards.Add(card);
            
            Console.WriteLine("the value of the card is:" + cards[0].Num[0,4]);
            
            return result;
        }

        public static int Part2(string[] numbers)
        {
            

            return result;
        }
    }
}