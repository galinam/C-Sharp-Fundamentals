using System;
class PrintADeck
{
    static void Main()
    {
        string inputCard = Console.ReadLine();
        int lastCard;
        bool result = true;

        inputCard.Trim();
        if ((inputCard == "J") || (inputCard == "j")) // L Q K A
        {
            lastCard = int.Parse("11");
        }
        else if ((inputCard == "Q") || (inputCard == "q")) // L Q K A
        {
            lastCard = int.Parse("12");
        }
        else if ((inputCard == "K") || (inputCard == "k")) // L Q K A
        {
            lastCard = int.Parse("13");
        }
        else if ((inputCard == "A") || (inputCard == "a")) // L Q K A
        {
            lastCard = int.Parse("14");
        }
        else
        {
            result = Int32.TryParse(inputCard, out lastCard);
        }
        if (result)
        {
            for (int i = 2; i <= lastCard; i++)
            {
                if ((i != 11) && (i != 12) && (i != 13) && (i != 14))
                {
                    Console.Write("{0} of spades, ", i);
                    Console.Write("{0} of clubs, ", i);
                    Console.Write("{0} of hearts, ", i);
                    Console.WriteLine("{0} of diamonds", i);
                }

                if (i == 11)
                {
                    Console.Write("J of spades, ");
                    Console.Write("J of clubs, ");
                    Console.Write("J of hearts, ");
                    Console.WriteLine("J of diamonds");
                }
                else if (i == 12)
                {
                    Console.Write("Q of spades, ");
                    Console.Write("Q of clubs, ");
                    Console.Write("Q of hearts, ");
                    Console.WriteLine("Q of diamonds");
                }
                else if (i == 13)
                {
                    Console.Write("K of spades, ");
                    Console.Write("K of clubs, ");
                    Console.Write("K of hearts, ");
                    Console.WriteLine("K of diamonds");
                }
                else if (i == 14)
                {
                    Console.Write("A of spades, ");
                    Console.Write("A of clubs, ");
                    Console.Write("A of hearts, ");
                    Console.WriteLine("A of diamonds");
                }
            }
        }
    }
}