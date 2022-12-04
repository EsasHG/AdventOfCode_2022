class Day3
{
    public void Run()
    {
        string[] lines = System.IO.File.ReadAllLines("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input_day3.txt");
        //PartOne(lines);
        PartTwo(lines);
    }
    void PartOne(string[] lines)
    {

        int sum = 0;
        foreach(string line in lines)
        {

            string firstComp = line.Substring(0,line.Length/2);
            string secondComp = line.Substring(line.Length/2,line.Length/2);
            char sharedChar = FindSharedChar(firstComp, secondComp);
            int pri = (int)(sharedChar);
            if(char.IsAsciiLetterLower(sharedChar))
                pri = pri - ((int)('a')-1);
            else if(char.IsAsciiLetterUpper(sharedChar))
                pri = pri - ((int)('A'))+27;
            sum += pri;
        }
        Console.WriteLine("Answer Part 1: " + sum);
    }
    void PartTwo(string[] lines)
    {
        int sum=0;
        for (int i = 0; i<lines.Count(); i+=3)
        {
            char sharedChar = FindSharedChar(lines[i], lines[i+1], lines[i+2]);
            int pri = (int)(sharedChar);
            if(char.IsAsciiLetterLower(sharedChar))
                pri = pri - ((int)('a')-1);
            else if(char.IsAsciiLetterUpper(sharedChar))
                pri = pri - ((int)('A'))+27;
            sum += pri;
        }
        Console.WriteLine("Answer Part 2: " + sum);
    }

    char FindSharedChar(string first, string second)
    {
        foreach(char c1 in first)
        {
            foreach(char c2 in second)
            {
                if(c1 == c2)
                    return c1;
            }
        }
        return '0';
    }

        char FindSharedChar(string first, string second, string third)
    {
        foreach(char c1 in first)
        {
            foreach(char c2 in second)
            {
                if(c1 == c2)
                {
                    foreach(char c3 in third)
                    {
                        if(c2 == c3)
                            return c3;
                    }
                
                }
            }
        }
        return '0';
    }

}