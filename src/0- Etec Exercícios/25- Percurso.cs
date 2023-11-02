using System;

public class Program
{
	public static void Main()
	{
		Percurso percurso = new Percurso(); //Cria objeto
		Custos custos = new Custos(); //Cria outro objeto
		int escolha = 4; //Declara um valor não ultilizado
		while (escolha != 0)
		{
			Console.WriteLine("Olá, escolha uma das opções:");
			Console.WriteLine("1- Novo percurso");
			Console.WriteLine("2- Listar percurso");
			Console.WriteLine("3- Calcular custos");
			Console.WriteLine("0- Sair");
			escolha = int.Parse(Console.ReadLine());
			if (escolha == 1)
			{
				Console.WriteLine("Insira km percorrido");
				percurso.kmPercorrida = double.Parse(Console.ReadLine()); 
				Console.WriteLine("Insira valor do combustível");
				percurso.valorCombustivel = double.Parse(Console.ReadLine());
				Console.WriteLine("Insira valor do pedagio");
				percurso.valorPedagio = double.Parse(Console.ReadLine());
				percurso = new Percurso(percurso.kmPercorrida, percurso.valorCombustivel, percurso.valorPedagio); //Ativa o construtor com 3 parametros
			}

			if (escolha == 2)
			{
				Console.WriteLine("");
				Console.WriteLine("Km percorrido: " + Percurso.listarPercurso(percurso.kmPercorrida) + "km"); //Mostra na tela
				Console.WriteLine("Valor combustível: " + Percurso.listarPercurso(percurso.valorCombustivel) + "L");
				Console.WriteLine("Valor pedágio: " + Percurso.listarPercurso(percurso.valorPedagio) + "R$");
				Console.WriteLine("");
			}

			if (escolha == 3)
			{
				Console.WriteLine("");
				Console.WriteLine("Custo total: " + Percurso.totalPercurso + "R$"); //Mostra na tela
			}
		}

		Console.WriteLine("Obrigado por usar!"); //Fim do programa
	}
}

public class Percurso
{
	public double kmPercorrida;
	public double valorCombustivel;
	public double valorPedagio;
	public static string totalPercurso; //Estatico para facilitar
	public Percurso() //Primeiro construtor
	{
		this.kmPercorrida = 0;
		this.valorCombustivel = 0;
		this.valorPedagio = 0;
		totalPercurso = "0";
	}

	public Percurso(double kmPercorrida, double valorCombustivel, double valorPedagio) //Segundo construtor
	{
		this.kmPercorrida = kmPercorrida;
		this.valorCombustivel = valorCombustivel;
		this.valorPedagio = valorPedagio;
		totalPercurso = Custos.calcularViagem(kmPercorrida, valorCombustivel, valorPedagio, totalPercurso); //Ativa método da classe custos
	}

	public static string listarPercurso(double variavel)
	{
		return variavel.ToString(); //Converte para string
	}
}

public class Custos
{
	public static string calcularViagem(double kmPercorrida, double valorCombustivel, double valorPedagio, string totalPercurso)
	{
		double temp = (kmPercorrida * valorCombustivel) + valorPedagio;
		totalPercurso = temp.ToString();
		return totalPercurso;
	}
}
