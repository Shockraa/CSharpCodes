using System;

class ConversorHexadecimal
{
	static void Main()
	{
		//Write a program that converts a decimal number to hexadecimal one.
		//Write a program that converts a hexadecimal number to decimal one.

		//Recomendado usar a versão mais recente do .NET
		
		Console.WriteLine("Olá amigo, como você deseja converter (digite o número correspondente)");
		Console.WriteLine("1- Decimal para hexadecimal");
		Console.WriteLine("2- Hexadecimal para decimal");
		int escolha = int.Parse(Console.ReadLine());
		if (escolha == 1)
		{
			Console.WriteLine("Insira o número decimal");
			int numeroDecimal = int.Parse(Console.ReadLine());
			string numeroHexadecimal = numeroDecimal.ToString("X"); //Esse X mostra que é hexadecimal
			Console.WriteLine("Número hexadecimal: " + numeroHexadecimal);
		}
		else if (escolha == 2)
		{
			Console.WriteLine("Insira o número hexadecimal");
			string numeroHexadecimal = Console.ReadLine();
			int numeroDecimal = Convert.ToInt32(numeroHexadecimal, 16); //Base 16 
			Console.WriteLine("Número decimal: " + numeroDecimal);
		}
		else
		{
			Console.WriteLine("Da para escolher uma das opções?, por sua causa você terá que executar o programa outra vez kkkk"); //Reutilizado :)
		}
	}
}
