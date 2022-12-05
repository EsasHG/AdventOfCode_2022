class Day5
{
    public void Run()
    {
        string[] lines = System.IO.File.ReadAllLines("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input_day5.txt");

                bool stacksLoaded = false;
        List<int> charIndexes = new List<int>(); 
        List<string> rows = new List<string>();
        List<Stack<Char>> stacks = new List<Stack<char>>();

        foreach(string line in lines)
        {
            if(stacksLoaded)
            {
                string[] command = line.Split(" ");
                //PartOne(stacks, command);
                PartTwo(stacks,command);
                
                continue;
            }

            
            if(!string.IsNullOrWhiteSpace(line))
            {
                rows.Add(line);
                continue;
            }
            else
            {
                stacksLoaded = true;

                string last = rows.Last();
                rows.Remove(rows.Last());
                int index=0;
                
                bool keepGoing = true;
                do
                {
                    index++;
                    int foundIndex = last.IndexOf(index.ToString());
                    if(foundIndex != -1)
                        charIndexes.Add(foundIndex);
                    else
                        keepGoing = false;

                }while(keepGoing);
                rows.Reverse();
                foreach(int charIndex in charIndexes)
                {
                    Stack<char> currentStack = new Stack<char>();
                    foreach(string row in rows)
                    {
                        char c = row[charIndex];
                        if(c != ' ')
                            currentStack.Push(c);
                    }
                    stacks.Add(currentStack);
                }
                continue;
            }
        }
        
        string answer = "";
        foreach(var s in stacks)
        {
            answer = answer + s.Peek();
        }
        Console.WriteLine("Answer Part 1: " + answer);
    }

    void PartOne(List<Stack<char>> stacks,string[] command)
    {
        for (int moves = int.Parse(command[1]); moves>0; moves--)
        {
            stacks[int.Parse(command[5])-1].Push(stacks[int.Parse(command[3])-1].Pop());
        }
    }

    void PartTwo(List<Stack<char>> stacks,string[] command)
    {
        Stack<char> charsToMove = new Stack<char>();
        for (int moves = int.Parse(command[1]); moves>0; moves--)
            charsToMove.Push(stacks[int.Parse(command[3])-1].Pop());
        
        while(charsToMove.Count != 0)
            stacks[int.Parse(command[5])-1].Push(charsToMove.Pop());
    }

}