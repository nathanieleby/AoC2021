using System;
using System.IO;

namespace AoC
{
    class GetInput
    {
        private static string[] contents;
        public static string[] ReadInputFile()
        {

            contents = File.ReadAllLines("input.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }

        public static string[] ReadInputFileBingo()
        {
            using (StreamReader input = new StreamReader("input4.txt"))
            {
                string temp = input.ReadLine();
                string[] randomInt = temp.Split(',');
             
                foreach (string line  in randomInt)
                {
                    Day4.bingoNums.Add(Int32.Parse(line));
                }


                int i = 0, j = 0;
                while(temp != null)
                {
                    bingoGameCard tempCard = new bingoGameCard();
                    for (i = 0; i < 5; i++)
                    {
                        temp = input.ReadLine();
                        if (temp == null)
                            break;

                        randomInt = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        if (randomInt.Length == 0)
                            i--;
                        else if (randomInt.Length == 5)
                        {
                            for (j = 0; j < 5; j++)
                            {
                                tempCard.Num[i, j] = Int32.Parse(randomInt[j]);                                
                            }

                            if (i == 4)
                            {
                                Day4.cards.Add(tempCard);

                            }
                        }
                    }  
                    
                }

            }
                     
         return contents;
        }
    }
}