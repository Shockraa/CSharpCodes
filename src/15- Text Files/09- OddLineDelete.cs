using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		// Write a program that deletes all the odd lines of a text file.
		try
		{
			string file = "exemplo.txt";
			using (StreamReader reader = new StreamReader(file))
			{
				string[] array = reader.ReadToEnd().Split('\n');
				using (StreamWriter writer = new StreamWriter(file))
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (i % 2 == 0)
						{
							writer.WriteLine(array[i]);
						}
					}
				}
			}
		}
		catch (FileNotFoundException e)
		{
			Console.WriteLine("File doesn't exist, " + e.Message);
		}
	}
} 
