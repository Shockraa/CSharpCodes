using System;
using ProjetoBancario; //Namespace feito por mim em outro arquivo da mesma numeração (22).
public class Program
{
    public static void Main()
    {
		Conta conta = new Conta(); //Cria uma conta bancaria
        int escolha = 4; //Declara um valor não ultilizado
        while (escolha != 0)
        {
            Console.WriteLine("Olá, escolha uma das opções:");
            Console.WriteLine("1- Entrada");
            Console.WriteLine("2- Retirada");
            Console.WriteLine("3- Consultar saldo");
            Console.WriteLine("0- Sair");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1) //Deposita
            {
				Console.Write("Digite o valor do depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Depositar(valorDeposito);
            }

 

            if (escolha == 2) //Retira
            {
				Console.Write("Digite o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Sacar(valorSaque);
            }

 

            if (escolha == 3) //Consulta
            {
				Console.WriteLine(conta.ConsultarSaldo());
            }
        }
    }
}
