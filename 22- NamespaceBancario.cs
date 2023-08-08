using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario //Usado no outro ex da mesma numeração (22)
{
   
    public class Conta
    {
        public double saldo;
        public int numero; //Cria valores

    public Conta()  //primeiro parametro
    {
        this.saldo = 0; //Atribui caso não possua argumentos
        this.numero = 0;
    }
     public Conta(double saldoInicial) //segundo parametro
    {
        if (saldoInicial >= 0)
        {
            saldo = saldoInicial;
        }
        else
        {
            saldo = 0;
        }
        numero = 0;
    }
    public Conta(int numeroConta) { //terceiro parametro
        saldo = 0;
        numero = numeroConta;
    }
    public void depositar(double valor) {
        if (valor > 0) {
            this.saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso"); //True
        } 
        else {
           Console.WriteLine("Valor inválido para depósito"); //False
        }
    }
    public string consultarSaldo() {
        return "Saldo atual: R$" + this.saldo;
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine("Depósito realizado");
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
    }

    public bool Sacar(double valor)
    {
        if (valor > 0 && saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado");
            return true;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou saque inválido");
            return false;
        }
    }

    public string ConsultarSaldo()
    {
        return "Saldo atual: R$" + saldo;
    }


    }
}
