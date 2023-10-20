using System;

public class Permulation
{
        //Write a recursive program, which generates and prints all permutations of the numbers 1, 2, …, n, for a given integer n.
	
	static int[] resposta; 
	static int n;
	static bool[] numerosUsados; // Array para acompanhar os números que já foram usados
	public static void Main()
	{
		Console.WriteLine("N?");
		n = int.Parse(Console.ReadLine());
		resposta = new int[n]; //Define a largura como n
		numerosUsados = new bool[n + 1]; // Inicializa o array com todos os valores false
		GetResposta(0); //Ativa método
	}

	public static void GetResposta(int loopAtual) //Declara
	{
		if (loopAtual == n) //Condição que mostra na tela e faz a recursão atual encerrar
		{
			MostrarLoop();
			return;
		}

		for (int i = 1; i <= n; i++)
		{
			if (!numerosUsados[i]) //Caso o número não seja usado ele é atribuido a resposta
			{
				resposta[loopAtual] = i;
				numerosUsados[i] = true; // Marca o número como usado
				GetResposta(loopAtual + 1); //Ativa recursão
				numerosUsados[i] = false; // Desmarca o número para que possa ser usado em outra combinação
			}
		}
	}

	static void MostrarLoop()
	{
		for (int i = 0; i < n; i++)
		{
			Console.Write("{0} ", resposta[i]); 
		}

		Console.WriteLine();
	}
}
