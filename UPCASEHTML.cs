using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		/*A text is given. Write a program that modifies the casing of letters to
                  uppercase at all places in the text surrounded by <upcase> and
                 </upcase> tags. Tags cannot be nested.*/
		
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

