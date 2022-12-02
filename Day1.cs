class Day1
{
    public void Run()
    {
        string[] lines = System.IO.File.ReadAllLines("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input.txt");
        List<int> elfs = new List<int>();

        int currentElf = 0;
        foreach(string line in lines)
        {
            if(string.IsNullOrWhiteSpace(line))
            {
                elfs.Add(currentElf);
                currentElf=0;
            }
            else
            {
                currentElf += int.Parse(line);
            }
        }
        elfs.Sort();

        int topThree = 0;
        for(int i = 1; i <4; i++)
        {
            topThree+=elfs[elfs.Count()-i];
        }
        Console.WriteLine(topThree);
    }
}