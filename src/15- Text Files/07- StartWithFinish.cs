using System;
using System.IO;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		/*Write a program that replaces every occurrence of the substring
                  "start" with "finish" in a text file. Can you rewrite the program to
                   replace whole words only? Does the program work for large files (e.g. 800
                   MB)?*/
		
		StreamReader reader = new StreamReader("input.txt");
		StreamWriter writer = new StreamWriter("output.txt");
		
		using (reader)
		{
			using (writer)
			{
				string line = reader.ReadLine();
				while (line != null)
				{
				      string modify = line.Replace("start", "finish");
                                      writer.WriteLine(modify);
				}
			}
		}
	}
}
