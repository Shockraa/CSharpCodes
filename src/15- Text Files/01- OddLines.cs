using System;
using System.IO;
					
public class Program
{
	public static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("exemplo.txt");
            string line = reader.ReadLine();
            int lineNum = 1;

            while (line != null)
            {
                if (lineNum % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
                lineNum++;
            }

            reader.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"O arquivo não existe: {e.Message}");
        }
    }
}
