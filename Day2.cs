class Day2
{
    int calculateScore(string opponent, string hand)
    {
        int loss = 0;
        int win = 6;
        int draw = 3;


        int score = 0;
        if(hand == "X")
        {
            score+=1;
            if(opponent == "A")
                score += draw;
            if(opponent == "B")
                score += loss;
            if(opponent == "C")
                score += win;
        }
        if(hand == "Y")
        {
            score+=2;
            if(opponent == "A")
                score += win;
            if(opponent == "B")
                score += draw;
            if(opponent == "C")
                score += loss;
        }
        if(hand == "Z")
        {
            score+=3;
            if(opponent == "A")
                score += loss;
            if(opponent == "B")
                score += win;
            if(opponent == "C")
                score += draw;
        }

        return score;
    }

string calculateResponseFromEnd(string opponent, string end)
    {
        string hand = "";
        if(end == "X")
        {
            if(opponent == "A")
                hand = "Z";
            if(opponent == "B")
                hand = "X";
            if(opponent == "C")
                hand = "Y";
        }
        if(end == "Y")
        {
            if(opponent == "A")
                hand = "X";
            if(opponent == "B")
                hand = "Y";
            if(opponent == "C")
                hand = "Z";
        }
        if(end == "Z")
        {
            if(opponent == "A")
                hand = "Y";
            if(opponent == "B")
                hand = "Z";
            if(opponent == "C")
                hand = "X";
        }

        return hand;
    }


    public void Run()
    {
        string[] lines = System.IO.File.ReadAllLines("D:\\Programming\\AdventOfCode\\AdventOfCode_2022\\Inputs\\Input_day2.txt");
        List<int> rounds = new List<int>();

        int endScore = 0;
        foreach(string line in lines)
        {
            string[] hands =  line.Split(" ",2);
            string yourHand = calculateResponseFromEnd(hands[0],hands[1]);
            endScore += calculateScore(hands[0], yourHand);

        }

        
        Console.WriteLine(endScore);
    }
}
