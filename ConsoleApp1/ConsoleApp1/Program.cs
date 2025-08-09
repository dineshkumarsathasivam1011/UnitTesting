using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (letterCount.ContainsKey(c))
                {
                    letterCount[c]++;
                }
                else
                {
                    letterCount[c] = 1;
                }

            }

            Console.WriteLine("LetterOccurance:");

            foreach (var kvp in letterCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

        }
        
    }

}
