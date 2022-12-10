/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/5
*/

namespace AdventOfCode._2015;

class Day5
{
    public static void Part1()
    {
        string[] input = File.ReadAllLines("../../../2015/Day5/input.txt");
        string[] nastys = new string[] { "ab", "cd", "pq", "xy" };
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        int count = 0;

        foreach (string line in input)
        {
            int vowelCount = 0;
            bool twoSameLetters = false;
            bool nastyString = false;

            foreach (char character in line)
            {
                if (vowels.Contains(character)) vowelCount++;
            }

            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] == line[i + 1]) twoSameLetters = true;
                if (nastys.Contains($"{line[i]}{line[i + 1]}")) nastyString = true;
            }

            if (vowelCount >= 3 && twoSameLetters && !nastyString) count++;
        }

        Console.WriteLine($"Part1: {count}");
    }

    public static void Part2()
    {
        string[] input = File.ReadAllLines("../../../2015/Day5/input.txt");
        int count = 0;

        foreach (string line in input)
        {
            bool twoDistantLetters = false;
            bool twoConsecutiveSameLetters = false;

            for (int i = 0; i < line.Length - 1; i++)
            {
                for (int j = i + 2; j < line.Length - 1; j++)
                {
                    if (line.Substring(i, 2) == line.Substring(j, 2)) twoDistantLetters = true;
                }
            }

            for (int i = 0; i < line.Length - 2; i++)
            {
                if (line[i] == line[i + 2]) twoConsecutiveSameLetters = true;
            }

            if (twoDistantLetters && twoConsecutiveSameLetters) count++;
        }

        Console.WriteLine($"Part2: {count}");
    }
}