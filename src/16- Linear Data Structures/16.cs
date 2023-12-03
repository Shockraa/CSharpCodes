using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        string display; //Write on console
        Queue<string> queue = new Queue<string>();
        string file = "C:\\";
        queue.Enqueue(file);

        while (queue.Count > 0) //Until it's empty
        {
            display = queue.Dequeue();
            Console.WriteLine(display);
            display = " "; //restart

            string[] directories;
            try 
            {
                directories = Directory.GetDirectories(file);
                foreach (string directory in directories)
                {
                    queue.Enqueue(directory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                continue;
            }
        }
    }
}
