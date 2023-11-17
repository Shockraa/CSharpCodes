using System;
using System.IO;
using System.Text.RegularExpressions;		
public class Program

{
	public static void Main()
	{
		string file = "exemplo.txt";
		string pattern = "<.*?>"; //sequencia
		string newtext = Regex.Replace(file, pattern, string.Empty); //trocar texto
		using (StreamWriter writer = new StreamWriter(file))
		{
			writer.WriteLine(newtext);
		}
	}
}
