using System;

public class SumOfTwoVeryLongNumbers
{
	public static void Main()
	{
		/*Write a method that calculates the sum of two very long positive
         integer numbers. The numbers are represented as array digits and
         the last digit (the ones) is stored in the array at index 0. Make the
         method work for all numbers with length up to 10,000 digits. */
		
		int[] a1 = new int[10000]; //Declara 2 arrays com a largura de 10000 conforme o exercício pediu
		int[] a2 = new int[10000];
		
		Console.WriteLine("Primeiro num?");
		string num1 = Console.ReadLine();
		if (num1.Length <= a1.Length) //Esse if e else verifica se o número dado ultrapassa a largura definida (Vai saber)
		{
			for (int i = 0; i < num1.Length; i++)
			{
				a1[i] = Convert.ToInt32(num1.Substring(num1.Length - 1 - i, 1)); //Preenche e reverte o array
			}
		}
		else
		{
			Console.WriteLine("Número ultrapassou 10,000 de largura");
		}

		Console.WriteLine("Segundo num?");
		string num2 = Console.ReadLine();
		if (num2.Length <= a2.Length)
		{
			for (int i = 0; i < num2.Length; i++)
			{
				a2[i] = Convert.ToInt32(num2.Substring(num2.Length - 1 - i, 1));
			}
		}
		else
		{
			Console.WriteLine("Número ultrapassou 10,000 de largura");
		}

		int larguraResultado = CalcularLargura(num1, num2); //Método para definir a largura do terceiro array que contém o resultado da soma
		int[] resultado = CalcularResultado(a1, a2, larguraResultado); //Método que calcula o resultado
		Array.Reverse(resultado); //Reverte o array resposta
		int teste = 0; //Variável para checar se o primeiro número do array = 0
		if (resultado[0] == 0)
			{
			   teste = 1; //Caso for 0, ele não é impresso na resposta.
			}

		for (int i = 0 + teste; i < larguraResultado; i++) //Loop para mostrar na tela
		{
			
				Console.Write(resultado[i]);
		}
	}

	public static int CalcularLargura(string num1, string num2)
	{
		int resultado = 0;
		if (num1.Length >= num2.Length) //Verifica qual é maior
		{
			resultado = num1.Length + 1;
		}
		else
		{
			resultado = num2.Length + 1;
		}

		return resultado;
	}
	public static int[] CalcularResultado(int[] a1, int[] a2, int larguraResultado)
	{
		int[] resultado = new int[larguraResultado];
		int guardar = 0;
		for (int i = 0; i < larguraResultado; i++)
		{
			if (a1[i] + a2[i] >= 10)
			{
			  resultado[i] = (a1[i] + a2[i] + guardar) % 10; //Soma os números de posição iguais nos arrays, o objetivo é pegar o ultimo digito da soma (Exemplo: 5+4 = 9 como não tem dois digitos então é adicionado o 9 no array resposta, agora se for 5+7 = 12, ele coloca o 2 no array resposta e guarda o 1 que será usado na próxima soma, portanto a próxima soma seria 3 + 5 + 1)
			  guardar = 1; //Guarda o número pra próxima soma 
			}
			else
			{
				resultado[i] = (a1[i] + a2[i] + guardar) % 10;
			    guardar = 0;
			}
			
		}
		return resultado;
	}
}
