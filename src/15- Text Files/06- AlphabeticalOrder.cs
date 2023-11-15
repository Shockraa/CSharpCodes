using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> students = new List<string> { };
        string path = "exemplo.txt";
        string finalPath = "destino.txt";

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] names = line.Split(' ');
                students.AddRange(names);
            }
        }
        students.Sort();
        using (StreamWriter writer = new StreamWriter(finalPath))
        {
            foreach (string name in students)
            {
                writer.Write(name + " ");
            }
        }



    }

}
