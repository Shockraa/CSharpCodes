using System;

class ConversorBinário
{
	static void Main()
	{
		//Write a program that converts a decimal number to binary one.
		//Write a program that converts a binary number to decimal one.
		
		Console.WriteLine("Olá amigo, como você deseja converter (digite o número correspondente)");
		Console.WriteLine("1- Decimal para binário");
		Console.WriteLine("2- Binário para decimal");
		int escolha = int.Parse(Console.ReadLine());
		if (escolha == 1)
		{
			Console.WriteLine("Insira o número decimal");
			int numeroDecimal = int.Parse(Console.ReadLine());
			string numeroBinario = Convert.ToString(numeroDecimal, 2);
			Console.WriteLine("Número binário: " + numeroBinario);
		}
		else if (escolha == 2)
		{
			Console.WriteLine("Insira o número binário");
			string numeroBinario = Console.ReadLine();
             int numeroDecimal = Convert.ToInt32(numeroBinario, 2);
             Console.WriteLine(numeroDecimal); 
		}
		else
		{
			Console.WriteLine("Da para escolher uma das opções?, por sua causa você terá que executar o programa outra vez kkkk");
		}
	}
}
