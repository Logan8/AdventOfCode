using System;
using System.IO;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            while (running)
            {
                Console.WriteLine("Enter which puzzle you want to run in a DAY-PUZZLE format.");
                Console.WriteLine("(E.g. for day 1, puzzle 1 write 1-1)");
                var puzzleNumer = Console.ReadLine();
                switch (puzzleNumer.ToLower())
                {
                    case "1-1":
                        DayOne.PuzzleOne();
                        break;

                    case "1-2":
                        DayOne.PuzzleTwo();
                        break;

                    case "exit":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("I haven't done that puzzle yet... Try again.");
                        break;
                }
            }
        }
    }
}
