using System;

public class Program
{
	public static void Main()
	{
		ContaCorrente cc = new ContaCorrente();
		ContaPoupanca cp = new ContaPoupanca();
		int opcao = 8; //Inicializado como valor qualquer
		while (opcao != 0)
		{
			Console.WriteLine("Escolha uma opção:");
			Console.WriteLine("1 - Conta Corrente");
			Console.WriteLine("2 - Conta Poupança");
			Console.WriteLine("0 - Sair");
			opcao = int.Parse(Console.ReadLine());
			switch (opcao)
			{
				case 1:
					MenuContaCorrente(cc);
					break;
				case 2:
					MenuContaPoupanca(cp);
					break;
				default:
					break;
			}
		}
	}

	static void MenuContaCorrente(ContaCorrente cc)
	{
		int opcao = 8;
		while (opcao != 0)
		{
			Console.WriteLine("Escolher opção da Conta Corrente:");
			Console.WriteLine("1 - Depositar");
			Console.WriteLine("2 - Sacar");
			Console.WriteLine("3 - Transferir");
			Console.WriteLine("4 - Consultar Saldo");
			Console.WriteLine("5 - Calcular Juros Cheque Especial");
			Console.WriteLine("0 - Sair");
			opcao = int.Parse(Console.ReadLine());
			switch (opcao)
			{
				case 1:
					Console.WriteLine("Valor deposito:");
					double valorDeposito = double.Parse(Console.ReadLine());
					cc.Depositar(valorDeposito);
					break;
				case 2:
					Console.WriteLine("Digite o valor para sacar:");
					double valorSaque = double.Parse(Console.ReadLine());
					bool saqueRealizado = cc.Sacar(valorSaque);
					if (saqueRealizado)
					{
						Console.WriteLine("Saque realizado");
					}
					else
					{
						Console.WriteLine("Saldo insuficiente.");
					}

					break;
				case 3:
					Console.WriteLine("Valor de transferencia");
					double valorTransferencia = double.Parse(Console.ReadLine());
					Console.WriteLine("Qual o numero da conta?");
					int numeroContaPoupanca = int.Parse(Console.ReadLine());
					ContaPoupanca destino = new ContaPoupanca(numeroContaPoupanca, 0);
					cc.Transferir(valorTransferencia, destino);
					break;
				case 4:
					Console.WriteLine(cc.ConsultarSaldo());
					break;
				case 5:
					Console.WriteLine("taxa de juros do cheque especial?");
					double taxaJuros = double.Parse(Console.ReadLine());
					cc.CalcularJuros(taxaJuros);
					Console.WriteLine($"Juros do Cheque Especial calculados: {cc.ConsultarSaldo()}");
					break;
				default:
					break;
			}
		}
	}

	static void MenuContaPoupanca(ContaPoupanca cp) //Poupança
	{
		int opcao = 8;
		while (opcao != 0)
		{
			Console.WriteLine("Escolha uma opção da Conta Poupança"); 
			Console.WriteLine("1 - Depositar");
			Console.WriteLine("2 - Sacar");
			Console.WriteLine("3 - Transferir");
			Console.WriteLine("4 - Consultar Saldo");
			Console.WriteLine("5 - Calcular Reajuste Mensal");
			Console.WriteLine("0 - Sair");
			opcao = int.Parse(Console.ReadLine());
			switch (opcao)
			{
				case 1:
					Console.WriteLine("Valor deposito?");
					double valorDeposito = double.Parse(Console.ReadLine());
					cp.Depositar(valorDeposito);
					break;
				case 2:
					Console.WriteLine("Valor de saque?");
					double valorSaque = double.Parse(Console.ReadLine());
					bool saqueRealizado = cp.Sacar(valorSaque);
					if (saqueRealizado)
					{
						Console.WriteLine("Saque realizado");
					}
					else
					{
						Console.WriteLine("Saldo insuficiente.");
					}

					break;
				case 3:
					Console.WriteLine("Valor transferencia");
					double valorTransferencia = double.Parse(Console.ReadLine());
					Console.WriteLine("número da Conta Corrente?");
					int numeroContaCorrente = int.Parse(Console.ReadLine());
					ContaCorrente destino = new ContaCorrente(numeroContaCorrente, 0, 0);
					cp.Transferir(valorTransferencia, destino);
					break;
				case 4:
					Console.WriteLine(cp.ConsultarSaldo());
					break;
				case 5:
					Console.WriteLine("Digite o percentual de reajuste mensal:");
					double percentualReajuste = double.Parse(Console.ReadLine());
					cp.CalcularRendimento(percentualReajuste);
					Console.WriteLine($"Reajuste Mensal: {cp.ConsultarSaldo()}");
					break;
				default:
					break;
			}
		}
	}
}

public class Conta
{
	public double saldo;
	public int Numero { get; }

	public Conta()
	{
		saldo = 0;
		Numero = 0;
	}

	public Conta(int numero)
	{
		saldo = 0;
		Numero = numero;
	}

	public Conta(int numero, double saldoInicial)
	{
		saldo = saldoInicial;
		Numero = numero;
	}

	public void Depositar(double valor)
	{
		if (valor > 0)
		{
			saldo += valor;
		}
	}

	public bool Sacar(double valor)
	{
		if (valor > 0 && saldo >= valor)
		{
			saldo -= valor;
			return true;
		}

		return false;
	}

	public void Transferir(double valor, Conta destino)
	{
		if (Sacar(valor))
		{
			destino.Depositar(valor);
		}
	}

	public string ConsultarSaldo()
	{
		return $"Saldo da Conta: {saldo:C}";
	}
}

public class ContaCorrente : Conta //Conta Corrente classe 
{
	private double limite;
	private double jurosChequeEspecial;
	public ContaCorrente() : base() // Classe conta
	{
		limite = 0;
		jurosChequeEspecial = 0;
	}

	public ContaCorrente(int numero, double saldoInicial, double limite) : base(numero, saldoInicial)
	{
		this.limite = limite;
		this.jurosChequeEspecial = 0;
	}

	public new bool Sacar(double valor)
	{
		if (valor > 0 && base.Sacar(valor)) //classe base método
		{
			return true;
		}

		return false;
	}

public void CalcularJuros(double taxa)
{
    if (saldo < 0)
    {
        jurosChequeEspecial = saldo * (taxa / 100); 
    }
}
	public new void Transferir(double valor, Conta destino)
    {
        if (Sacar(valor))
        {
            destino.Depositar(valor);
        }
    }
	public new string ConsultarSaldo()
    {
        return $"Saldo da Conta {Numero}: {saldo:C}";
    }
}

public class ContaPoupanca : Conta //Conta poupança classe 
{
	private double reajusteMensal;

	public ContaPoupanca()
	{
		reajusteMensal = 0;
	}
    public ContaPoupanca(int numero, double saldoInicial) : base(numero, saldoInicial)
    {
        reajusteMensal = 0;
    }

    public void CalcularRendimento(double percentual)
    {
        if (saldo > 0)
        {
            reajusteMensal = saldo * (percentual / 100); //Rendimento  normal
            AtualizarSaldo();
        }
    }

    private void AtualizarSaldo()
    {
        saldo += reajusteMensal;
    }
}

