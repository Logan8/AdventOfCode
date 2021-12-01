using System;
using System.IO;

namespace AdventOfCode
{
    class DayOne
    {
        const string input = "Resources/DayOneInput.txt";

        public static void PuzzleOne()
        {
            var content = File.ReadAllLines(input);

            var first = 0;
            var second = 0;
            var increases = 0;

            foreach (var line in content)
            {
                if (first == 0 && second == 0)
                {
                    Int32.TryParse(line, out first);
                }
                else
                {
                    Int32.TryParse(line, out second);
                    if (second > first) increases++;
                    first = second;
                }
            }

            Console.WriteLine("Increased " + increases.ToString() + " times.");
        }
    }
}