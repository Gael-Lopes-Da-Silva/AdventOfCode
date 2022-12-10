/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/8
*/

namespace AdventOfCode._2015;

class Day8
{
    public static void Part1()
    {
        string input = File.ReadAllText("../../../2015/Day8/input.txt");
        int codeCharacters = 0;
        int memoryCharacters = 0;

        foreach (char character in input)
        {
            if (character == '\n') continue;
            codeCharacters++;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '\n') continue;
            if (input[i] == '"') continue;

            if (input[i] == '\\')
            {
                if (input[i + 1] == '"')
                {
                    i++;
                    memoryCharacters++;
                }
                else if (input[i + 1] == '\\')
                {
                    i++;
                    memoryCharacters++;
                }
                else if (input[i + 1] == 'x')
                {
                    i += 3;
                    memoryCharacters++;
                }
            }
            else
            {
                memoryCharacters++;
            }
        }

        Console.WriteLine($"Part1: {codeCharacters} - {memoryCharacters} = {codeCharacters - memoryCharacters}");
    }

    public static void Part2()
    {
        string input = File.ReadAllText("../../../2015/Day8/input.txt");
        int encodedCodeCharacters = 0;

        foreach (char character in input)
        {
            if (character == '\n') continue;
            encodedCodeCharacters++;
        }

        int codeCharacters = encodedCodeCharacters;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '\n') continue;
            if (input[i] == '"')
            {
                encodedCodeCharacters += 2;
                continue;
            }

            if (input[i] == '\\')
            {
                if (input[i + 1] == '"')
                {
                    i++;
                    encodedCodeCharacters += 2;
                }
                else if (input[i + 1] == '\\')
                {
                    i++;
                    encodedCodeCharacters += 2;
                }
                else if (input[i + 1] == 'x')
                {
                    i += 3;
                    encodedCodeCharacters++;
                }
            }
        }

        Console.WriteLine($"Part2: {encodedCodeCharacters} - {codeCharacters} = {encodedCodeCharacters - codeCharacters}");
    }
}