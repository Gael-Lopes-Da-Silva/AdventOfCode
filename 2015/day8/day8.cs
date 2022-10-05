void Part1()
{
    string input = File.ReadAllText("./input.txt");
    int codeCharacters = 0;
    int memoryCharacters = 0;
    int count = 0;

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
            if (input[i+1] == '"')
            {
                i++;
                memoryCharacters++;
            }
            else if (input[i+1] == '\\') 
            {
                i++;
                memoryCharacters++;
            }
            else if (input[i+1] == 'x')
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

    count = codeCharacters - memoryCharacters;

    Console.WriteLine($"Part1: {codeCharacters} - {memoryCharacters} = {count}");
}

void Part2()
{
    string input = File.ReadAllText("./input.txt");
    int encodedCodeCharacters = 0;
    int codeCharacters = 0;
    int count = 0;

    foreach (char character in input)
    {
        if (character == '\n') continue;
        encodedCodeCharacters++;
    }

    codeCharacters = encodedCodeCharacters;
    
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
            if (input[i+1] == '"')
            {
                i++;
                encodedCodeCharacters += 2;
            }
            else if (input[i+1] == '\\') 
            {
                i++;
                encodedCodeCharacters += 2;
            }
            else if (input[i+1] == 'x')
            {
                i += 3;
                encodedCodeCharacters++;
            }
        }
    }

    count = encodedCodeCharacters - codeCharacters;

    Console.WriteLine($"Part2: {encodedCodeCharacters} - {codeCharacters} = {count}");
}

void Main()
{
    Part1();
    Part2();
} Main();
