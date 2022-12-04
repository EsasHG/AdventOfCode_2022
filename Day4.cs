class Day4
{
    public void Run()
    {
        string[] lines = System.IO.File.ReadAllLines("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input_day4.txt");
        PartOne(lines);
        PartTwo(lines);
    }
    void PartOne(string[] lines)
    {
        int sum = 0;
        foreach(string line in lines)
        {
            string[] pair = line.Split(",",2);
            string[] firstElf = pair[0].Split("-",2);
            int firstElfStart =int.Parse(firstElf[0]);
            int firstElfEnd = int.Parse(firstElf[1]);

            string[] secondElf = pair[1].Split("-",2);
            int secondElfStart = int.Parse(secondElf[0]);
            int secondElfEnd = int.Parse(secondElf[1]);
            if(firstElfStart <= secondElfStart && firstElfEnd >= secondElfEnd)
                sum++;
            else if(firstElfStart >= secondElfStart && firstElfEnd <= secondElfEnd)
                sum++;
        }
        Console.WriteLine("Answer Part 1: " + sum);
    }
    void PartTwo(string[] lines)
    {
        int sum=0;
        foreach(string line in lines)
        {
            string[] pair = line.Split(",",2);
            string[] firstElf = pair[0].Split("-",2);
            int firstElfStart =int.Parse(firstElf[0]);
            int firstElfEnd = int.Parse(firstElf[1]);

            string[] secondElf = pair[1].Split("-",2);
            int secondElfStart = int.Parse(secondElf[0]);
            int secondElfEnd = int.Parse(secondElf[1]);
                 if(firstElfStart <= secondElfStart && firstElfEnd >= secondElfEnd)     //completely overlaps
                sum++;
            else if(firstElfStart >= secondElfStart && firstElfEnd <= secondElfEnd)     //completely overlaps
                sum++;
            else if(firstElfStart <= secondElfStart && firstElfEnd >= secondElfStart)   //first overlaps start of second
                sum++;
            else if(firstElfStart <= secondElfEnd && firstElfEnd >= secondElfEnd)       //first overlaps end of second
                sum++;
            else if(secondElfStart <= firstElfStart && secondElfEnd >= firstElfStart)   //second overlaps start of first
                sum++;
            else if(secondElfStart <= firstElfEnd && secondElfEnd >= firstElfEnd)       //second overlaps start of first
                sum++;
        }
        Console.WriteLine("Answer Part 2: " + sum);
    }

}