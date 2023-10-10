using System;
using System.Text; //Importação para usar StringBuilder

public class Program
{
//Ex 2
    public static void Main()
    {
        Console.WriteLine("Insira qualquer coisa para inverter");
        string resposta = Console.ReadLine();
        Console.WriteLine(Reverso(resposta)); //Método do StringBuilder
    }

    static string Reverso(string resposta)
    {
        StringBuilder sb = new StringBuilder(); 
        for (int i = resposta.Length - 1; i >= 0; i--)
        {
            sb.Append(resposta[i]);
        }

        return sb.ToString();
    }
}
