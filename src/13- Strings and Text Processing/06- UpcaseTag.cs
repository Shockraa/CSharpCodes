using System;
using System.Text.RegularExpressions; //Import para usar RegEx
					
public class Program
{
	public static void Main()
	{
		/*A text is given. Write a program that modifies the casing of letters to
                  uppercase at all places in the text surrounded by <upcase> and
                 </upcase> tags. Tags cannot be nested.*/
		
		Console.WriteLine("Input html text"); //Use: <upcase> </upcase>
		string frase = Console.ReadLine();
		string modificada = Modificar(frase); //Método para modificar a frase
		 Console.WriteLine(modificada);
	}
	public static string Modificar(string frase)
	{
		string seq = @"<upcase>(.*?)</upcase>";
		string result = Regex.Replace(frase, seq, match => //Match metodo
        {
            string content = match.Groups[1].Value;
            return content.ToUpper(); //Retorna o conteudo entre as tags upcase 
        });

        return result;
		
	}
}

