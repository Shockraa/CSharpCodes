using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Insira uma frase");
		string frase = Console.ReadLine();
		Console.WriteLine("Insira as palavras para censurar (separe-as com virgula de preferência)");
        string censura = Console.ReadLine();
		
		string resultado = Censurar(frase, censura);
        
        Console.WriteLine(resultado);
    }

    static string Censurar(string text, string censura)
    {

        string[] wordsArray = censura.Split(',');


        string seq = string.Join("|", wordsArray) ;  //operador lógico para diferenciar seq

       
        string result = Regex.Replace(text, seq, match => new string('*', match.Length));

        return result;
    }
	
}

