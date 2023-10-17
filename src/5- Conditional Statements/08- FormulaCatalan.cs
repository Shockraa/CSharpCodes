using System;

class Catalan
{
	static void Main()
	{
		// Write a program that calculates the nth Catalan number by given n
		//Formula do Catalan: http://en.wikipedia.org/wiki/Catalan_number
		Console.WriteLine("n?");
		int n = int.Parse(Console.ReadLine()); //Primeiro número que será fatorado
		int m = n + 1; //Segundo número que será fatorado
		int y = n * 2; //Terceiro número que será fatorado
		double fatorialN = 1, fatorialX = 1, fatorialY = 1; //Fatoriais que serão usados na formula
		for (int i = 1; i <= n; i++) //Calcular primeiro fatorial
		{
			fatorialN *= i;
		}

		for (int j = 1; j <= m; j++) //Calcular segundo fatorial
		{
			fatorialX *= j;
		}

		for (int k = 1; k <= y; k++) //Calcular terceiro fatorial
		{
			fatorialY *= k;
		}

		double catalan = fatorialY / (fatorialX * fatorialN); //Formula para descobrir o catalan de acordo com o N
		Console.WriteLine(catalan); //Resultado
	}
}
