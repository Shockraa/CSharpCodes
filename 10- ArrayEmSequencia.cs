using System;

class ArrayEmSequencia
{
	static void Main()
	{
		/*Write a program, which finds the maximal sequence of consecutively 
          placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

		

		Console.WriteLine("Largura do array em número inteiro?");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n]; //array do usuário
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("Insira o número da posição" + i);
			array[i] = int.Parse(Console.ReadLine());
		}

		int[] resultado = new int[array.Length];
		int larguraAuxiliar = 1; //Temporária
		int largura = int.MinValue; //Definitiva
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] > array[i - 1] && array[i-1] + 1 == array[i]) //Compara atual com anterior | Verifica se o array atual tem 1 número de diferença do anterior (se não ficaria 2, 3, 4, 7 em vez de apenas 2, 3, 4)
			{
				larguraAuxiliar++;
				if (larguraAuxiliar > largura)
				{
					largura = larguraAuxiliar; //Transfere pra largura definitiva
					for (int j = 0; j < largura; j++)
					{
						resultado[j] = array[i + j - largura + 1]; //Passa para o resultado, essa equação atinge todos os números da sequência.
					}
				}
			}
			else
			{
				larguraAuxiliar = 1; // resetar a repetição auxiliar
			}
		}

		Console.WriteLine("A maior sequência do Array é:");
		for (int i = 0; i < largura; i++)
		{
			Console.WriteLine(resultado[i] + " "); //Resposta
		}
	}
}
