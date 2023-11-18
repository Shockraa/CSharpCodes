using System;
using System.IO;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string filePath = "exemplo.txt";
        string outputPath = "output.txt";

        DeleteWordsStartingWith(filePath, outputPath, "test");
    }

    static void DeleteWordsStartingWith(string inputPath, string outputPath, string prefix)
    {
        try
        {
            string content = File.ReadAllText(inputPath);

            // Use regular expression to match words starting with the specified prefix
            string pattern = @"\b" + Regex.Escape(prefix) + @"\w*\b";
            content = Regex.Replace(content, pattern, string.Empty);

            File.WriteAllText(outputPath, content);
            Console.WriteLine("Words starting with '" + prefix + "' deleted. Output written to " + outputPath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
