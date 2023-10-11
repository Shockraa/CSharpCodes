using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite uma frase");
		string frase = Console.ReadLine();
		string modificada = Modificar(frase);
		 Console.WriteLine(modificada);
	}
	public static string Modificar(string frase)
	{
		string seq = @"<upcase>(.*?)</upcase>";
		string result = Regex.Replace(frase, seq, match =>
        {
            string content = match.Groups[1].Value;
            return content.ToUpper();
        });

        return result;
		
	}
}

