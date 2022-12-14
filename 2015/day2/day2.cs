/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/2
*/

namespace AdventOfCode._2015;

class Day2
{
    public static void Part1()
    {
        string[] input = File.ReadAllLines("../../../2015/Day2/input.txt");
        int count = 0;

        foreach (string line in input)
        {
            int[] values = Array.ConvertAll(line.Split('x'), x => int.Parse(x)); ;

            Array.Sort(values);
            count += 2 * values[0] * values[1] + 2 * values[1] * values[2] + 2 * values[0] * values[2];
            count += values[0] * values[1];
        }

        Console.WriteLine($"Part1: {count}");
    }

    public static void Part2()
    {
        string[] input = File.ReadAllLines("../../../2015/Day2/input.txt");
        int count = 0;

        foreach (string line in input)
        {
            int[] values = Array.ConvertAll(line.Split('x'), x => int.Parse(x)); ;

            Array.Sort(values);
            count += values[0] * values[1] * values[2];
            count += values[0] + values[0] + values[1] + values[1];
        }

        Console.WriteLine($"Part2: {count}");
    }
}