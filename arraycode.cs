using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example array of strings
        string[] originalArray = {
            "This is a sample sentence.",
            "Sample sentence with consecutive words.",
            "Another example with words.",
            "This is another sample."
        };

        string[] resultArray = GetFirstThreeConsecutiveWords(originalArray);

        // Display the result
        foreach (var result in resultArray)
        {
            Console.WriteLine(result);
        }
    }

    static string[] GetFirstThreeConsecutiveWords(string[] inputArray)
    {
        List<string> result = new List<string>();

        foreach (string sentence in inputArray)
        {
            string[] words = sentence.Split(' ');

            // Find the first three consecutive words
            for (int i = 0; i <= words.Length - 3; i++)
            {
                string consecutiveWords = $"{words[i]} {words[i + 1]} {words[i + 2]}";

                // Check if these consecutive words appear in any other string
                if (!inputArray.Any(otherSentence => otherSentence != sentence && otherSentence.Contains(consecutiveWords)))
                {
                    result.Add(consecutiveWords);
                    break; // Break after finding the first occurrence
                }
            }
        }

        return result.ToArray();
    }
}
