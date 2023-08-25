using System;

public class Program
{
	public static void Main()
	{
		Comanda controleMesa = new Comanda(); //Cria objeto
		Caixa caixa = new Caixa(); //Cria outro objeto
		int escolha = 5; //Declara um valor não ultilizado
		while (escolha != 0)
		{
			Console.WriteLine("Olá, escolha uma das opções:");
			Console.WriteLine("1 – Lançar gastos");
			Console.WriteLine("2 – Verificar promoção");
			Console.WriteLine("3 – Fechar mesa");
			Console.WriteLine("4 – Listar comanda");
			Console.WriteLine("0- Sair");
			escolha = int.Parse(Console.ReadLine());
			if (escolha == 1)
			{
				Comanda.lancarGastos();
			}

			if (escolha == 2)
			{
				Comanda.verificarPromocao();
			}

			if (escolha == 3)
			{
				Caixa.totalizarComanda(controleMesa);
			}

			if (escolha == 4)
			{
			//Opção mostrar (ignorar)
			}
		}

		Console.WriteLine("Obrigado por usar!"); //Fim do programa
	}
}

public class Comanda
{
	private int id;
	private static double valorConsumo;
	private double valorEstacionamento;
	private double valorCouvert;
	private static double valorDescontoPromocional;
	private double valorTotal;
	
	public Comanda()
	{
		this.id = 0; //Exemplo
		valorConsumo = 0;
		this.valorEstacionamento = 0;
		this.valorCouvert = 0;
	}

	public Comanda(double refvalorConsumo, double valorEstacionamento, double valorCouvert)
	{
		valorDescontoPromocional = 0;
		this.valorTotal = 0;
		valorConsumo = refvalorConsumo;
		this.valorEstacionamento = valorEstacionamento;
		this.valorCouvert = valorCouvert;
	}
	public Comanda(int id)
	{
		this.id = 0;
	}

	public static void lancarGastos()
	{
		Console.WriteLine("Valor consumido?");
		double refvalorConsumo = double.Parse(Console.ReadLine());
		Console.WriteLine("Valor estacionamento?");
		double valorEstacionamento = double.Parse(Console.ReadLine());
		Console.WriteLine("Valor couvert?");
		double valorCouvert = double.Parse(Console.ReadLine());
		Comanda controleMesa = new Comanda(refvalorConsumo, valorEstacionamento, valorCouvert); //Segundo construtor
		Console.WriteLine("Os gastos foram lançados.");
	}

	public static void verificarPromocao()
	{
		if (valorConsumo > 100)
		{
			Console.WriteLine("Você recebeu um desconto de 10%");
			valorDescontoPromocional = valorConsumo / 10;
		}
		else
		{
			Console.WriteLine("Sem desconto >:( ");
		}
		
	}

	public static void listarComanda()
	{
	}
}

public class Caixa
{
	public static void totalizarComanda(Comanda controleMesa)
    {
        double total = Comanda.ValorTotal;

        Console.WriteLine("Total da comanda: " + total);
    }
}
