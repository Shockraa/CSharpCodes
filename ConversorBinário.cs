using System;

class ConversorBinário
{
	static void Main()
	{
		//Write a program that converts a decimal number to binary one.
		
		Console.WriteLine("Olá amigo, como você deseja converter (digite o número correspondente");
		Console.WriteLine("1- Decimal para binário");
		int escolha = int.Parse(Console.ReadLine());
		if (escolha == 1)
		{
			Console.WriteLine("Insira o número decimal");
			int numeroDecimal = int.Parse(Console.ReadLine());
			string numeroBinario = Convert.ToString(numeroDecimal, 2);
			Console.WriteLine("Número binário: " + numeroBinario);
		}
	}
}
