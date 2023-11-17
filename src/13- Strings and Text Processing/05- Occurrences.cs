using System;

public class Program
{
	public static void Main()
	{
         /*Write a program that detects how many times a substring is contained in
           the text. For example, let’s look for the substring "in" in the text: */
    
		Console.WriteLine("Insira uma frase");
		string quote = Console.ReadLine();
		quote.ToLower(); //Necessário diminuir letras para evitar erro caso tenha letra maiuscula
		string palavraChave = "in";
		int num = quote.IndexOf(palavraChave);
		while (num != -1)
		{
			Console.WriteLine("{0} foi encontrado no num: {1}", palavraChave, num);
			num = quote.IndexOf(palavraChave, num + 1);
		}
	}
}

