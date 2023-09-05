using System;

public class Program
{
    public static void Main()
    {
        Comanda controleMesa = new Comanda();
        Caixa caixa = new Caixa();
        int escolha = 5; 

        while (escolha != 0)
        {
            Console.WriteLine("Olá, escolha uma das opções:");
            Console.WriteLine("1 – Lançar gastos");
            Console.WriteLine("2 – Verificar promoção");
            Console.WriteLine("3 – Fechar mesa");
            Console.WriteLine("4 – Listar comanda");
            Console.WriteLine("0 - Sair");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                controleMesa.LancarGastos();
            }

            if (escolha == 2)
            {
                controleMesa.VerificarPromocao();
            }

            if (escolha == 3)
            {
                Console.WriteLine("Valor total da comanda: " + Caixa.TotalizarComanda(controleMesa));
            }

            if (escolha == 4)
            {
                controleMesa.ListarComanda();
            }
        }

        Console.WriteLine("Obrigado, volte sempre!");
    }
}

public class Comanda
{
    private int id;
    private double valorConsumo;
    private double valorEstacionamento;
    private double valorCouvert;
    private double valorDescontoPromocional;
    private double valorTotal;

    public Comanda() //Primeiro construtor
    {
        this.id = 0;
        this.valorConsumo = 0;
        this.valorEstacionamento = 0;
        this.valorCouvert = 0;
    }

    public Comanda(double refvalorConsumo, double valorEstacionamento, double valorCouvert) //Segundo construtor com os valores recebidos
    {
        this.valorDescontoPromocional = 0;
        this.valorTotal = 0;
        this.valorConsumo = refvalorConsumo;
        this.valorEstacionamento = valorEstacionamento;
        this.valorCouvert = valorCouvert;
    }

    public Comanda(int id) //Terceiro construtor para inicializar o ID
    {
        this.id = 0;
    }

    public void LancarGastos()
    {
        Console.WriteLine("Valor consumido?");
        double refvalorConsumo = double.Parse(Console.ReadLine());
        Console.WriteLine("Valor estacionamento?");
        double valorEstacionamento = double.Parse(Console.ReadLine());
        Console.WriteLine("Valor couvert?");
        double valorCouvert = double.Parse(Console.ReadLine());

        // Atribuir os valores aos atributos da comanda atual
        this.valorConsumo = refvalorConsumo;
        this.valorEstacionamento = valorEstacionamento;
        this.valorCouvert = valorCouvert;

        Console.WriteLine("Os gastos foram lançados.");
    }

    public void VerificarPromocao()
    {
        if (this.valorConsumo > 100)
        {
            Console.WriteLine("Você recebeu um desconto de 10%");
            this.valorDescontoPromocional = this.valorConsumo * 0.1;
			this.valorTotal = this.valorTotal - this.valorDescontoPromocional;
        }
        else
        {
            Console.WriteLine("Sem desconto >:(");
        }
    }

    public void ListarComanda()
    {
        Console.WriteLine($"Valor Consumo: {this.valorConsumo}"); //Exibir valores
        Console.WriteLine($"Valor Estacionamento: {this.valorEstacionamento}");
        Console.WriteLine($"Valor Couvert: {this.valorCouvert}");
        Console.WriteLine($"Desconto Promocional: {this.valorDescontoPromocional}");
        this.valorTotal = this.valorConsumo + this.valorEstacionamento + this.valorCouvert - this.valorDescontoPromocional;
        Console.WriteLine($"Valor Total: {this.valorTotal}");
    }

    public double ValorTotal
    {
        get { return this.valorTotal; }
    }
}

public class Caixa
{
    public static double TotalizarComanda(Comanda controleMesa)
    {
        double total = controleMesa.ValorTotal;
        return total;
    }
}
