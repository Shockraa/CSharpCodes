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

            List<string> wordsContent = ReadList(words);
            List<string> wordsContent2 = ReadList(text);
            List<string> result = wordsContent.Intersect(wordsContent2).ToList(); //Searches for same words and store in a list

            Console.WriteLine("Words found in both files: "); //Display
            foreach (string word in result)
            {
                Console.WriteLine(word + "");
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


}
