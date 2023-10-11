using System;

public class Program
{
	public static void Main()
	{
    //Lembrete ex 5
    
		Console.WriteLine("Insira uma frase");
		string quote = Console.ReadLine();
		quote.ToLower();
		string palavraChave = "in";
		int num = quote.IndexOf(palavraChave);
		while (num != -1)
		{
			Console.WriteLine("{0} foi encontrado no num: {1}", palavraChave, num);
			num = quote.IndexOf(palavraChave, num + 1);
		}
	}
}

