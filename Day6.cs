class Day6
{
    public void Run()
    {
        string line = System.IO.File.ReadAllText("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input_day6.txt");
        string answerPart1 = FindFirstXDistinct(line, 4);
        string answerPart2 = FindFirstXDistinct(line, 14);
 
        Console.WriteLine("Answer Part 1: "+ answerPart1);
        Console.WriteLine("Answer Part 2: "+ answerPart2);
    }

    string FindFirstXDistinct(string line, int x)
    {
        Queue<char> q = new Queue<char>();
        int i=0;
        foreach (char c in line)
        {
            if(q.Distinct().Count() == x)
                return i.ToString();
            else if(q.Count == x)
                q.Dequeue();
            
            q.Enqueue(c);
            i++;
        } 
        return "error";
    }
}