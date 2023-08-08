using System;
using System.Data;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Insira uma expressão numérica");
        string conta = Console.ReadLine();
        DataTable dt = new DataTable();

        try
        {
            object resultado = dt.Compute(conta, "");
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
