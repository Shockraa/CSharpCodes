using System;
					
public class Program
{
	public static void Main()
	{ 
		Console.WriteLine("Insira uma expressão numérica");
		string exp = Console.ReadLine();
        char[] charArray = exp.ToCharArray();
		int contador = 0;
		
		for (int i = 0; i < charArray.Length; i++)
		{
			if (charArray[i] == '(')
			{
				contador++;
			}
			if (charArray[i] == ')')
			{
				contador--;
			}
		}
		if (contador == 0)
		{
		   Console.WriteLine("É uma expressão numérica valida");
		}
		else
		{
			Console.WriteLine("Não é uma expressão numérica valida");
		}
	}
}
