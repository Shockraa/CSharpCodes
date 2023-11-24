using System;
using System.IO;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		//Write the previous program so that it changes only the whole words (not parts of the word)
		
		StreamReader reader = new StreamReader("input.txt");
		StreamWriter writer = new StreamWriter("output.txt");
		
		using (reader)
		{
			using (writer)
			{
				string line = reader.ReadLine();
				while (line != null)
				{
					string modify = line.Replace(@"\bstart\b", "finish"); // gotta surround with \b so it only replaces the whole start
                                        writer.WriteLine(modify);
				}
			}
		}
	}
}
