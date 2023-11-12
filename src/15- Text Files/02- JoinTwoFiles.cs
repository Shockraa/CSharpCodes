using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        try
        {
            StreamReader reader1 = new StreamReader("exemplo1.txt");
            StreamReader reader2 = new StreamReader("exemplo2.txt");
            StreamWriter writer = new StreamWriter("exemplo3.txt");


            using (reader1)
            {
                using (reader2)
                {
                    using (writer)
                    {
                        string line1 = reader1.ReadLine();
                        while(line1 != null)
                        {
                            writer.WriteLine(line1);
                            line1 = reader1.ReadLine();
                        }
                        string line2 = reader2.ReadLine();

                        while(line2 != null)
                        {
                            writer.WriteLine(line2);
                            line2 = reader2.ReadLine();
                        }

                    }
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"O arquivo não existe: {e.Message}");
        }
    }
}
