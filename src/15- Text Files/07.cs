using System;
using System.IO;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
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
