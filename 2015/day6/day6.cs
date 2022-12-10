/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/6
*/

namespace AdventOfCode._2015;

class Day6
{
    public static void Part1()
    {
        string[] input = File.ReadAllLines("../../../2015/Day6/input.txt");
        int[,] lightGrid = new int[1000, 1000];
        int count = 0;

        foreach (string line in input)
        {
            string[] splitedLine = line.Split(' ');

            if (splitedLine[0] == "turn")
            {
                string[] firstValue = splitedLine[2].Split(',');
                string[] secondValue = splitedLine[4].Split(',');

                if (splitedLine[1] == "on")
                {
                    for (int x = int.Parse(firstValue[0]); x <= int.Parse(secondValue[0]); x++)
                    {
                        for (int y = int.Parse(firstValue[1]); y <= int.Parse(secondValue[1]); y++)
                        {
                            lightGrid[x, y] = 1;
                        }
                    }
                }
                else if (splitedLine[1] == "off")
                {
                    for (int x = int.Parse(firstValue[0]); x <= int.Parse(secondValue[0]); x++)
                    {
                        for (int y = int.Parse(firstValue[1]); y <= int.Parse(secondValue[1]); y++)
                        {
                            lightGrid[x, y] = 0;
                        }
                    }
                }
            }
            else if (splitedLine[0] == "toggle")
            {
                string[] firstValue = splitedLine[1].Split(',');
                string[] secondValue = splitedLine[3].Split(',');

                for (int x = int.Parse(firstValue[0]); x <= int.Parse(secondValue[0]); x++)
                {
                    for (int y = int.Parse(firstValue[1]); y <= int.Parse(secondValue[1]); y++)
                    {
                        if (lightGrid[x, y] == 1) lightGrid[x, y] = 0;
                        else if (lightGrid[x, y] == 0) lightGrid[x, y] = 1;
                    }
                }
            }
        }

        for (int x = 0; x < 1000; x++)
        {
            for (int y = 0; y < 1000; y++)
            {
                if (lightGrid[x, y] == 1) count++;
            }
        }

        Console.WriteLine($"Part1: {count}");
    }

    public static void Part2()
    {
        string[] input = File.ReadAllLines("../../../2015/Day6/input.txt");
        int[,] lightGrid = new int[1000, 1000];
        int brightness = 0;

        foreach (string line in input)
        {
            string[] splitedLine = line.Split(' ');

            if (splitedLine[0] == "turn")
            {
                string[] firstValue = splitedLine[2].Split(',');
                string[] secondValue = splitedLine[4].Split(',');

                if (splitedLine[1] == "on")
                {
                    for (int x = int.Parse(firstValue[0]); x <= int.Parse(secondValue[0]); x++)
                    {
                        for (int y = int.Parse(firstValue[1]); y <= int.Parse(secondValue[1]); y++)
                        {
                            lightGrid[x, y] += 1;
                        }
                    }
                }
                else if (splitedLine[1] == "off")
                {
                    for (int x = int.Parse(firstValue[0]); x <= int.Parse(secondValue[0]); x++)
                    {
                        for (int y = int.Parse(firstValue[1]); y <= int.Parse(secondValue[1]); y++)
                        {
                            if (lightGrid[x, y] > 0) lightGrid[x, y] -= 1;
                        }
                    }
                }
            }
            else if (splitedLine[0] == "toggle")
            {
                string[] firstValue = splitedLine[1].Split(',');
                string[] secondValue = splitedLine[3].Split(',');

                for (int x = int.Parse(firstValue[0]); x <= int.Parse(secondValue[0]); x++)
                {
                    for (int y = int.Parse(firstValue[1]); y <= int.Parse(secondValue[1]); y++)
                    {
                        lightGrid[x, y] += 2;
                    }
                }
            }
        }

        for (int x = 0; x < 1000; x++)
        {
            for (int y = 0; y < 1000; y++)
            {
                brightness += lightGrid[x, y];
            }
        }

        Console.WriteLine($"Part2: {brightness}");
    }
}