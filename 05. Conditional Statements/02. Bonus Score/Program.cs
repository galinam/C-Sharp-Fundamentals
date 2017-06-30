using System;

class BonusScores
{
    static void Main()
    {        
        short score = short.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3: score *= 10;
                Console.WriteLine(score); break;
            case 4:
            case 5:
            case 6: score *= 100;
                Console.WriteLine(score); break;
            case 7:
            case 8:
            case 9: score *= 1000;
                Console.WriteLine(score); break;
            default: Console.WriteLine("invalid score");
                break;
        }
    }
}