using System;
					
public class Program
{
	public static void Main()
	{ 
//Lembrete: Ex 3

/*Write a program that checks whether the parentheses are placed
correctly in an arithmetic expression. Example of expression with
correctly placed brackets: ((a+b)/5-d). Example of an incorrect
expression: )(a+b)).*/

		Console.WriteLine("Insert a numerical expression");
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
		   Console.WriteLine("It is valid!");
		}
		else
		{
			Console.WriteLine("lol, not valid!");
		}
	}
}
