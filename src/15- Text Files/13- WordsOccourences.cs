using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        try
        {
            string words = "words.txt"; //Name for the files
            string text = "text.txt";
            string result = "result.txt";

            List<string> wordsContent = ReadList(words);
            List<string> wordsContent2 = ReadList(text);
            List<string> final = wordsContent.Intersect(wordsContent2).ToList(); //Searches for same words and store in a list

             Dictionary<string, int> wordOccurrences = WordOccurrences(wordsContent, final);

            
            var sortedResults = wordOccurrences.OrderByDescending(pair => pair.Value);

           
            using (StreamWriter writer = new StreamWriter(result))
            {
                foreach (var pair in sortedResults)
                {
                    writer.WriteLine("Word: " + pair.Key +"Occourences: " + pair.Value);
                }
            }
        }
        catch (FileNotFoundException ex) //All exceptions here (at least the ones I found)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Unauthorized access: {ex.Message}");
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine($"Out of memory exception: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"IO exception: {ex.Message}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Null reference exception: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Argument exception: {ex.Message}");
        }

    }
    static List<string> ReadList(string file) 
    {
        string temp = File.ReadAllText(file); //System.IO method to read text
        string[] content = temp.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '(', ')', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries); //Stuff to separate and find the words
        return content.ToList();
    }
    static Dictionary<string, int> WordOccurrences(List<string> words, List<string> allWords)
    {
        Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();

        foreach (string word in allWords)
        {
            if (wordOccurrences.ContainsKey(word))
            {
                wordOccurrences[word]++;
            }
            else
            {
                wordOccurrences[word] = 1;
            }
        }

        return wordOccurrences;
    }


}
