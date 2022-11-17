void Part1()
{
    string[] input = File.ReadAllLines("./input.txt");
    List<string> locations = new List<string>();
    int[] distances = new int[100];
    int count = 1000;
    int timer = 0;
    int index = 0;
    
    foreach (string line in input)
    {
        string[] splitedLine = line.Split(' ');
        
        if (!locations.Contains(splitedLine[0])) locations.Add(splitedLine[0]);
        if (!locations.Contains(splitedLine[1])) locations.Add(splitedLine[1]);
        
        foreach (string word in splitedLine)
        {
            if (timer == 4)
            {
                distances[index] = int.Parse(word);

                index++;
                timer = 0;
            }
            else 
            {
                timer++;
            }
        }
    }

    for (int i = 0; i < distances.Length; i++)
    {
        for (int k = 0; k < distances.Length; k++)
        {
            if (count > distances[i]+distances[k] && i != k)
            {
                if (distances[i] == 0 || distances[k] == 0) continue;

                count = distances[i]+distances[k];
            }
        }
    }

    Console.WriteLine($"Part1: {count}");
}

void Part2()
{
    string[] input = File.ReadAllLines("./input.txt");

    foreach (string line in input)
    {

    }
}

void Main()
{
    Part1();
    Part2();
} Main();
