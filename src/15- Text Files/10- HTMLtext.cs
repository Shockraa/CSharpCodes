using System;
using System.IO;
using System.Text.RegularExpressions;		
public class Program

{
	public static void Main()
	{
		//Write a program that extracts from an XML file the text only (without the tags).
		string file = "exemplo.txt";
		string pattern = "<.*?>";
		string newtext = Regex.Replace(file, pattern, string.Empty); 
		using (StreamWriter writer = new StreamWriter(file))
		{
			writer.WriteLine(newtext);
		}
	}
}
