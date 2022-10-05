/* 
@author: Gael Lopes Da Silva
@project: Advent Of Code
@github: https://github.com/Gael-Lopes-Da-Silva/AdventOfCode
@gitlab: https://gitlab.com/Gael-Lopes-Da-Silva/AdventOfCode
@day: https://adventofcode.com/2015/day/3
*/

void Part1()
{
    string input = File.ReadAllText("./input.txt");
    bool alreadyVisited = false;
    int count = 1;
    int index = 1;
    int x = 0;
    int y = 0;

    int[,] roadMape = new int[9000,2];

    foreach (char character in input)
    {
        if (character == '>') x++;
        else if (character == '<') x--;
        else if (character == '^') y++;
        else if (character == 'v') y--;

        for (int i = 1; i < roadMape.GetLength(0); i++)
        {
            if (roadMape[i,0] == x && roadMape[i,1] == y)
            {
                alreadyVisited = true;
            }
        }

        if (!alreadyVisited)
        {
            roadMape[index,0] = x;
            roadMape[index,1] = y;
            count++;
        }
        
        index++;
        alreadyVisited = false;
    }

    Console.WriteLine($"Part1: {count}");
}

void Part2()
{
    string input = File.ReadAllText("./input.txt");
    bool santaAlreadyVisited = false;
    bool robotSantaAlreadyVisited = false;
    int count = 1;
    int index = 1;
    int x1 = 0, y1 = 0;
    int x2 = 0, y2 = 0;

    int[,] roadMape = new int[9000,2];

    foreach (char character in input)
    {
        if (index%2 == 0)
        {
            if (character == '>') x2++;
            else if (character == '<') x2--;
            else if (character == '^') y2++;
            else if (character == 'v') y2--;
        }
        else
        {
            if (character == '>') x1++;
            else if (character == '<') x1--;
            else if (character == '^') y1++;
            else if (character == 'v') y1--;
        }

        for (int i = 1; i < roadMape.GetLength(0); i++)
        {
            if (roadMape[i,0] == x1 && roadMape[i,1] == y1)
            {
                santaAlreadyVisited = true;
            }
            if (roadMape[i,0] == x2 && roadMape[i,1] == y2)
            {
                robotSantaAlreadyVisited = true;
            }
        }

        if (!santaAlreadyVisited)
        {
            roadMape[index,0] = x1;
            roadMape[index,1] = y1;
            count++;
        }
        if (!robotSantaAlreadyVisited)
        {
            roadMape[index,0] = x2;
            roadMape[index,1] = y2;
            count++;
        }
        
        index++;
        santaAlreadyVisited = false;
        robotSantaAlreadyVisited = false;
    }

    Console.WriteLine($"Part2: {count}");
}

void Main()
{
    Part1();
    Part2();
} Main();
