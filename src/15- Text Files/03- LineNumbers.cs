using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        try
        {
            string[] linhas = File.ReadAllLines("exemplo.txt");
            StreamWriter writer = new StreamWriter("exemplo.txt");

            using (writer)
            {

                for (int i = 0; i < linhas.Length; i++)
                {
                    writer.WriteLine((i + 1) + linhas[i]);
                }
            }

        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"O arquivo não existe: {e.Message}");
        }
    }
}
