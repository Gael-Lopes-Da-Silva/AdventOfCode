/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/1
*/

namespace AdventOfCode._2015;

class Day1
{
    public static void Part1()
    {
        string input = File.ReadAllText(@"../../../2015/Day1/input.txt");
        int count = 0;

        foreach (char character in input)
        {
            if (character == '(') count++;
            else if (character == ')') count--;
        }

        Console.WriteLine($"Part1: {count}");
    }

    public static void Part2()
    {
        string input = File.ReadAllText(@"../../../2015/Day1/input.txt");
        int count = 0;
        int index = 0;

        foreach (char character in input)
        {
            if (count == -1) break;

            if (character == '(') count++;
            else if (character == ')') count--;

            index++;
        }

        Console.WriteLine($"Part2: {index}");
    }
}