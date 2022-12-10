/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/7
*/

namespace AdventOfCode._2015;

class Day7
{
    private static Dictionary<string, string> circuit = new Dictionary<string, string>();
    private static Dictionary<string, int> cache = new Dictionary<string, int>();

    private static int Compute(string value)
    {
        if (cache.ContainsKey(value)) return cache[value];
        if (int.TryParse(value, out int result)) return result;

        value = circuit[value];

        if (value.Contains("NOT")) return ~Compute(value.Split(' ')[1]) & 0xffff;

        try
        {
            string[] valueComponents = value.Split(' ');

            cache[valueComponents[0]] = Compute(valueComponents[0]);
            cache[valueComponents[2]] = Compute(valueComponents[2]);

            if (valueComponents[1] == "AND") return Compute(valueComponents[0]) & Compute(valueComponents[2]);
            else if (valueComponents[1] == "OR") return Compute(valueComponents[0]) | Compute(valueComponents[2]);
            else if (valueComponents[1] == "LSHIFT") return Compute(valueComponents[0]) << Compute(valueComponents[2]);
            else if (valueComponents[1] == "RSHIFT") return Compute(valueComponents[0]) >> Compute(valueComponents[2]);
        }
        catch
        {
            return Compute(value);
        }

        return 0;
    }

    public static void Part1()
    {
        string[] input = File.ReadAllLines("../../../2015/Day7/input.txt");

        foreach (string line in input)
        {
            string[] splitedLine = line.Split(" -> ");
            circuit[splitedLine[1]] = splitedLine[0];
        }

        Console.WriteLine($"Part1: {Compute("a")}");
        cache.Clear();
    }

    public static void Part2()
    {
        string[] input = File.ReadAllLines("../../../2015/Day7/input.txt");

        foreach (string line in input)
        {
            string[] splitedLine = line.Split(" -> ");
            circuit[splitedLine[1]] = splitedLine[0];
        }

        circuit["b"] = Compute("a").ToString();
        cache.Clear();

        Console.WriteLine($"Part2: {Compute("a")}");
        cache.Clear();
    }
}