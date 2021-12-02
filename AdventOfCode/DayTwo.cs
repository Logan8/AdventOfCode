using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
    class DayTwo
    {
        const string UP = "up";
        const string DOWN = "down";
        const string FORWARD = "forward";

        const string input = "Resources/DayTwoInput.txt";

        public static void PuzzleOne()
        {
            var content = File.ReadAllLines(input);

            Dictionary<string, int> valuesDict = new Dictionary<string, int>();

            foreach (var line in content)
            {
                int num;
                var entry = line.Split(" ");
                if (Int32.TryParse(entry[1], out num))
                {
                    if (valuesDict.ContainsKey(entry[0]))
                    {
                        valuesDict[entry[0]] = valuesDict[entry[0]] + num;
                    }
                    else
                    {
                        valuesDict.Add(entry[0], num);
                    }
                }
            }

            int vertical = valuesDict[DOWN] - valuesDict[UP]; ;
            int horizontal = valuesDict[FORWARD];

            Console.WriteLine("Multiplied positon is " + (vertical * horizontal).ToString() + ".");
        }

        public static void PuzzleTwo()
        {
            var content = File.ReadAllLines(input);
            int aim = 0;
            int horizontal = 0;
            int vertical = 0;

            foreach (var line in content)
            {
                int num;
                var entry = line.Split(" ");
                if (Int32.TryParse(entry[1], out num))
                {
                    switch (entry[0])
                    {
                        case UP:
                            aim -= num;
                            break;

                        case DOWN:
                            aim += num;
                            break;

                        case FORWARD:
                            horizontal += num;
                            vertical += (aim * num);
                            break;
                    }
                }
            }

            Console.WriteLine("Multiplied positon is " + (vertical * horizontal).ToString() + ".");
        }
    }
}