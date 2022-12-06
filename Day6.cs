class Day6
{
    public void Run()
    {
        string line = System.IO.File.ReadAllText("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input_day6.txt");
        string answerPart1 = PartOne(line);
        string answerPart2 = PartTwo(line);
 
        Console.WriteLine("Answer Part 1: "+ answerPart1);
        Console.WriteLine("Answer Part 2: "+ answerPart2);
    }

    string PartOne(string line)
    {
        Queue<char> q = new Queue<char>();
        int i=0;
        foreach (char c in line)
        {
            if(q.Distinct().Count() == 4)
                return i.ToString();
            else if(q.Count == 4)
                q.Dequeue();
            
            q.Enqueue(c);
            i++;
        } 
        return "error";
    }

    string PartTwo(string line)
    {
        Queue<char> q = new Queue<char>();
        int i=0;
        foreach (char c in line)
        {
            if(q.Distinct().Count() == 14)
                return i.ToString();
            else if(q.Count == 14)
                q.Dequeue();
            
            q.Enqueue(c);
            i++;
        } 
        return "error";
    }

}