using System;

namespace AoC
{
    class Day2
    {
        public static int Part1(string[] directions)
        {
            int depth = 0;
            int distance = 0;
            for(int i = 0; i <directions.Length; i++) 
            {
                string direction = directions[i].Split(' ')[0];
                int value = int.Parse(directions[i].Split(' ')[1]);
                if (direction == "forward")
                    distance += value;
                if (direction == "down")
                    depth += value;
                if (direction == "up")
                    depth -= value;
            }
            
            Console.WriteLine("Answer = " + distance * depth);
                
            return distance * depth;
        }

        public static int Part2(string[] directions)
        {
            int depth = 0;
            int horizontal = 0;
            int aim = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                string direction = directions[i].Split(' ')[0];
                int value = int.Parse(directions[i].Split(' ')[1]);
                if (direction == "forward")
                {   
                    horizontal += value;
                    depth += (aim * value);
                }
                if (direction == "down")
                    aim += value;
                if (direction == "up")
                    aim -= value;
            }

            Console.WriteLine("Answer = " + horizontal * depth);

            return horizontal * depth;
        }
    }
}