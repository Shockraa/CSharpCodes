using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        string display; //Write on console
        Stack<string> stack = new Stack<string>(); //Modification to stack
        string file = "C:\\"; //Root directory
        stack.Push(file);

        while (stack.Count > 0) //Until it's empty
        {
            display = stack.Pop();
            Console.WriteLine(display);
            display = " "; //restart

            string[] directories;
            try 
            {
                directories = Directory.GetDirectories(file);
                foreach (string directory in directories)
                {
                    stack.Push(directory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                continue;
            }
        }
    }
}
