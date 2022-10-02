/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/4
*/

using System.Text;
using System.Security.Cryptography;

void Part1()
{
    int index = 0;

    while (true)
    {
        MD5 md5 = MD5.Create();
        string key = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes($"iwrupvqb{index}"))).Replace("-", "");
        
        if (key[0] == '0' && key[1] == '0' && key[2] == '0' && key[3] == '0' && key[4] == '0') break;
        
        index++;
    }

    Console.WriteLine($"Part1: {index}");
}

void Part2()
{
    int index = 0;

    while (true)
    {
        MD5 md5 = MD5.Create();
        string key = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes($"iwrupvqb{index}"))).Replace("-", "");
        
        if (key[0] == '0' && key[1] == '0' && key[2] == '0' && key[3] == '0' && key[4] == '0' && key[5] == '0') break;
        
        index++;
    }

    Console.WriteLine($"Part2: {index}");
}

void Main()
{
    Part1();
    Part2();
} Main();
