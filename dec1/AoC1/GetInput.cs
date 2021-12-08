using System;
using System.IO;

namespace AoC
{
    class GetInput
    {
        public static string[] contents;
        public static string[] ReadInputFile()
        {

            contents = File.ReadAllLines("input.txt");

            Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }

        public static string[] ReadInputFileBingo()
        {

            contents = File.ReadAllLines("input4.txt");

            //contents = File.("input4.txt");
            using (StreamReader input = new StreamReader("input4.txt"))
            {
                string temp = input.ReadLine();
                string[] randomsInt = temp.Split(',');

                foreach (string line in randomsInt)
                    Day4.bingoNumbers.Add(Int32.Parse(line));

                //while((temp = input.ReadLine()) != null)
                //{
                //
                //}


            }
            
            
           
               // Console.WriteLine("Input File Lenght: " + contents.Length);

            return contents;
        }
    }
}