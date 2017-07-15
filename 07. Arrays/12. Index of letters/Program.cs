using System;

class IndexOfLetters
{
    static void Main()
    {
        // Input
        //Console.Write("Enter word: ");
        char[] word = Console.ReadLine().ToCharArray();

        // Solution
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                          'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (char.ToLower(word[i]) == letters[j])
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}