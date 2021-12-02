using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
    class DayOne
    {
        const string input = "Resources/DayOneInput.txt";

        public static void PuzzleOne()
        {
            var content = File.ReadAllLines(input);

            List<int> valuesArray = new List<int>();

            foreach (var line in content)
            {
                int result;
                if (Int32.TryParse(line, out result))
                {
                    valuesArray.Add(result);
                }
            }

            var increases = GetIncreases(valuesArray.ToArray());

            Console.WriteLine("Increased " + increases.ToString() + " times.");
        }

        public static void PuzzleTwo()
        {
            var content = File.ReadAllLines(input);

            List<int> summedArray = new List<int>();
            var first = 0;
            var second = 0;
            var third = 0;

            foreach (var line in content)
            {
                if (first == 0 && second == 0 && third == 0)
                {
                    Int32.TryParse(line, out first);
                }
                else if (second == 0 && third == 0)
                {
                    Int32.TryParse(line, out second);
                }
                else
                {
                    Int32.TryParse(line, out third);
                    summedArray.Add(first + second + third);
                    first = second;
                    second = third;
                }
            }

            GetIncreases(summedArray.ToArray());

            var increases = GetIncreases(summedArray.ToArray());

            Console.WriteLine("Increased " + increases.ToString() + " times.");
        }

        private static int GetIncreases(int[] valuesList)
        {
            var first = 0;
            var second = 0;
            var increases = 0;

            foreach (var value in valuesList)
            {
                if (first == 0 && second == 0)
                {
                    first = value;
                }
                else
                {
                    second = value;
                    if (second > first) increases++;
                    first = second;
                }
            }

            return increases;
        }
    }
}