using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
    class DayTwo
    {
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

            int vertical = valuesDict["down"] - valuesDict["up"]; ;
            int horizontal = valuesDict["forward"];


            Console.WriteLine("Multiplied positon is " + (vertical * horizontal).ToString() + ".");
        }

        public static void PuzzleTwo()
        {

        }
    }
}